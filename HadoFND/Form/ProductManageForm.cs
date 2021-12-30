using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HadoFND
{
    public partial class ProductManageForm : MetroFramework.Forms.MetroForm // 상속 클래스 변경
    {
        ConfigFile _configFile = new ConfigFile();

        MySqlConnection conn;
        int selectedCodeNumber = 0;

        public ProductManageForm()
        {
            InitializeComponent();
        }

        private void ProductManageForm_Load(object sender, EventArgs e)
        {
            SetDefaultValue();
        }
        
        //
        // 폼 로드시 가져오는 데이터
        //
        private void SetDefaultValue()
        {
            try
            {
                //
                // 환경설정 파일 로드
                //
                _configFile = _configFile.Load();

                string connectString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};", _configFile.Db_IP, _configFile.Db_NAME, _configFile.Db_ID, _configFile.Db_PW);
                conn = new MySqlConnection(connectString);
                conn.Open();

                var sqlselect = "SELECT name, unit_weight, code_number FROM product WHERE deleted_at is null ORDER BY code_number ASC;";
                MySqlCommand cmd = new MySqlCommand(sqlselect, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                ProductList_Datagridview.DataSource = dt;

                ProductCodeNumber_TextBox.Text = "";
                ProductName_TextBox.Text = "";
                ProductWeight_TextBox.Text = "";
            }
            catch (Exception ex)
            {
                Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
            }
            finally
            {
                conn.Close();
            }
        }

        //
        // 제품 등록 버튼
        //
        private void ProductAdd_Button_Click(object sender, EventArgs e)
        {
            var codeNumber = ProductCodeNumber_TextBox.Text;
            var name = ProductName_TextBox.Text;
            var unitWeight = ProductWeight_TextBox.Text;

            //
            // 입력값 제대로 입력했는지 확인
            //
            if (codeNumber == null || codeNumber.Equals(""))
            {
                var text = "품번을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (name == null || name.Equals(""))
            {
                var text = "제품명을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (unitWeight == null || unitWeight.Equals(""))
            {
                var text = "표준중량을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            //
            // 입력한 품번으로 등록된 제품이 있는지 확인
            //

            try
            {
                conn.Open();

                var sqlSelect = "SELECT * FROM product WHERE code_number = @code_number and deleted_at is null;";
                MySqlCommand cmd = new MySqlCommand(sqlSelect, conn);
                cmd.Parameters.AddWithValue("@code_number", Convert.ToInt32(codeNumber));
                MySqlDataReader dr = cmd.ExecuteReader();

                // 동일 정보로 등록된 제품 있을 경우
                if (dr.HasRows)
                {
                    var text = "등록된 제품이 있습니다. 제품명과 품번을 확인해주세요.";
                    MessageBox.Show(text);
                    return;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
            }
            finally
            {
                
            }

            //
            // 등록된 제품 없으면 DB에 저장
            //

            try
            {
                var sqlInsert = "INSERT INTO product ( id, name, unit_weight, code_number, created_at, deleted_at ) VALUES (@id, @name, @unit_weight, @code_number, @created_at, @deleted_at)";
                MySqlCommand cmd = new MySqlCommand(sqlInsert, conn);

                cmd.Parameters.AddWithValue("@id", Guid.NewGuid().ToString());
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@unit_weight", Convert.ToInt32(unitWeight));
                cmd.Parameters.AddWithValue("@code_number", Convert.ToInt32(codeNumber));
                cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                cmd.Parameters.AddWithValue("@deleted_at", null);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
            }
            finally
            {
                conn.Close();
                var text = "제품이 등록되었습니다.";
                MessageBox.Show(text);
                SetDefaultValue();
            }
        }

        //
        // 데이터 선택 시 이벤트 처리
        //
        private void ProductList_Datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            // 선택한 셀의 품번(Code_Number)으로 이벤트 처리
            //
            if (ProductList_Datagridview.SelectedCells[2] == null)
            {
                selectedCodeNumber = 0;
                return;
            }

            if (ProductList_Datagridview.SelectedCells[2].Value.ToString().Equals("") || ProductList_Datagridview.SelectedCells[2].Value.ToString() == null)
            {
                selectedCodeNumber = 0;
                return;
            }

            selectedCodeNumber = Convert.ToInt32(ProductList_Datagridview.SelectedCells[2].Value);
        }

        //
        // 제품 삭제 버튼
        //
        private void ProductDelete_Button_Click(object sender, EventArgs e)
        {
            //
            // 제품 선택 했는지 확인
            //
            if(selectedCodeNumber == 0)
            {
                var text = "삭제할 제품을 선택해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (MessageBox.Show("선택한 제품을 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                conn.Open();

                // 선택한 제품의 품번으로 DB에서 검색                
                var sqlSelect = "SELECT * FROM product WHERE code_number = @code_number and deleted_at is null;";
                MySqlCommand cmd = new MySqlCommand(sqlSelect, conn);
                cmd.Parameters.AddWithValue("@code_number", selectedCodeNumber);
                MySqlDataReader dr = cmd.ExecuteReader();
                
                // 제품 있을 경우에 삭제 실행
                if (dr.HasRows)
                {
                    dr.Close();
                    var sqlUpdate = "UPDATE product SET deleted_at = @deleted_at WHERE code_number = @code_number;";
                    cmd = new MySqlCommand(sqlUpdate, conn);
                    cmd.Parameters.AddWithValue("@code_number", selectedCodeNumber);
                    cmd.Parameters.AddWithValue("@deleted_at", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
            }
            finally
            {
                var text = "제품이 삭제되었습니다.";
                MessageBox.Show(text);
                conn.Close();
                SetDefaultValue();
            }
        }

        //
        // 품번의 입력을 숫자로 제한
        //
        private void ProductCodeNumber_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        //
        // 표준중량의 입력을 숫자로 제한
        //
        private void ProductWeight_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
    }
}
