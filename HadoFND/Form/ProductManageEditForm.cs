using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HadoFND.Form
{
    public delegate void ProductManageEditClosedEventHandler();

    public partial class ProductManageEditForm : MetroFramework.Forms.MetroForm
    {
        ConfigFile _configFile = new ConfigFile();
        public static int currentProductCodeNumber; // 현재 로그인한 계정 id
        public ProductManageEditClosedEventHandler ProductManageEditClosedEvent;
        MySqlConnection conn;

        public ProductManageEditForm()
        {
            InitializeComponent();
        }

        private void ProductManageEditForm_Load(object sender, EventArgs e)
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

                var sqlselect = "SELECT * FROM product WHERE deleted_at is null and code_number = @code_number;";
                MySqlCommand cmd = new MySqlCommand(sqlselect, conn);
                cmd.Parameters.AddWithValue("@code_number", currentProductCodeNumber);
                MySqlDataReader dr = cmd.ExecuteReader();

                if(dr.HasRows)
                {
                    dr.Read();

                    ProductEditCodeNumber_TextBox.Text = dr["code_number"].ToString();
                    ProductEditName_TextBox.Text = dr["name"].ToString();
                    ProductEditWeight_TextBox.Text = dr["unit_weight"].ToString();
                }
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
        // 제품 수정 버튼
        //
        private void ProductEditUpdate_Button_Click(object sender, EventArgs e)
        {
            //
            // 입력값 모두 입력 했는지 확인
            //
            var codeNumber = ProductEditCodeNumber_TextBox.Text;
            var name = ProductEditName_TextBox.Text;
            var unitWeight = ProductEditWeight_TextBox.Text;

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

            try
            {
                conn.Open();

                var inputCodeNumber = Convert.ToInt32(codeNumber);
                // 품번은 변경하지 않고 수정
                if(inputCodeNumber == currentProductCodeNumber)
                {
                    var sqlUpdate = "UPDATE product SET name = @name, unit_weight = @unit_weight, code_number = @update_code_number WHERE code_number = @code_number;";
                    MySqlCommand cmd = new MySqlCommand(sqlUpdate, conn);
                    cmd = new MySqlCommand(sqlUpdate, conn);
                    cmd.Parameters.AddWithValue("@code_number", currentProductCodeNumber);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@unit_weight", Convert.ToInt32(unitWeight));
                    cmd.Parameters.AddWithValue("@update_code_number", inputCodeNumber);

                    cmd.ExecuteNonQuery();

                    var text = "제품이 수정 되었습니다.";
                    MessageBox.Show(text);
                    conn.Close();
                }
                // 품번 변경하고 수정
                // 중복되는 품번 있는지 체크
                else
                {
                    // 입력한 품번으로 DB에서 검색                
                    var sqlSelect = "SELECT * FROM product WHERE code_number = @code_number and deleted_at is null;";
                    MySqlCommand cmd = new MySqlCommand(sqlSelect, conn);
                    cmd.Parameters.AddWithValue("@code_number", inputCodeNumber);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    // 해당 품번의 제품 있을 경우 팝업으로 안내 띄우기
                    if (dr.HasRows)
                    {
                        var text = "입력하신 품번은 이미 등록되어있습니다. 다른 품번을 입력해주세요.";
                        MessageBox.Show(text);
                        conn.Close();
                        return;
                    }
                    // 해당 품번의 제품 없을 경우 수정
                    else
                    {
                        dr.Close();
                        var sqlUpdate = "UPDATE product SET name = @name, unit_weight = @unit_weight, code_number = @update_code_number WHERE code_number = @code_number;";
                        cmd = new MySqlCommand(sqlUpdate, conn);
                        cmd.Parameters.AddWithValue("@code_number", currentProductCodeNumber);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@unit_weight", Convert.ToInt32(unitWeight));
                        cmd.Parameters.AddWithValue("@update_code_number", inputCodeNumber);

                        cmd.ExecuteNonQuery();

                        var text = "제품이 수정 되었습니다.";
                        MessageBox.Show(text);
                        conn.Close();
                    }
                }                
            }
            catch (Exception ex)
            {
                Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
            }
            finally
            {
                
            }
        }

        // 제품 수정 닫기 버튼
        private void ProductEditClose_Button_Click(object sender, EventArgs e)
        {
            ProductManageEditClosedEvent();
            this.Close();
        }

        private void ProductEditCodeNumber_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void ProductEditWeight_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void ProductManageEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProductManageEditClosedEvent();
        }
    }
}
