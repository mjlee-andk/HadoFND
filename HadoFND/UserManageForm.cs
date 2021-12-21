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

namespace HadoFND
{
    public partial class UserManageForm : MetroFramework.Forms.MetroForm // 상속 클래스 변경
    {
        string connectString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};", "127.0.0.1", "hado", "root", "root");
        MySqlConnection conn;
        string selectedUserId = "";

        public UserManageForm()
        {
            InitializeComponent();
        }

        private void UserManageForm_Load(object sender, EventArgs e)
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
                conn = new MySqlConnection(connectString);
                conn.Open();

                var sqlselect = "SELECT id, account, name FROM user WHERE deleted_at is null ORDER BY name ASC;";
                MySqlCommand cmd = new MySqlCommand(sqlselect, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                UserList_Datagridview.DataSource = dt;

                UserName_TextBox.Text = "";
                UserAccount_TextBox.Text = "";
                UserPassword_TextBox.Text = "";
                UserPasswordConfirm_TextBox.Text = "";
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }


        //
        // 유저 등록 버튼
        //
        private void UserAdd_Button_Click(object sender, EventArgs e)
        {
            var userName = UserName_TextBox.Text;
            var userAccount = UserAccount_TextBox.Text;
            var userPassword = UserPassword_TextBox.Text;
            var userPasswordConfirm = UserPasswordConfirm_TextBox.Text;

            //
            // 입력값 제대로 입력했는지 확인
            //
            if (userName == null || userName.Equals(""))
            {
                var text = "이름을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (userAccount == null || userAccount.Equals(""))
            {
                var text = "아이디를 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (userPassword == null || userPassword.Equals(""))
            {
                var text = "비밀번호를 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (userPasswordConfirm == null || userPasswordConfirm.Equals(""))
            {
                var text = "비밀번호 확인을 입력해주세요.";
                MessageBox.Show(text);
                return;
            }

            if(userPassword != userPasswordConfirm)
            {
                var text = "비밀번호와 비밀번호 확인이 서로 다릅니다. 입력한 값을 확인해주세요.";
                MessageBox.Show(text);
                return;
            }

            //
            // 아이디 중복 확인 
            //

            try
            {
                conn.Open();

                var sqlSelect = "SELECT * FROM user WHERE account = @account and deleted_at is null;";
                MySqlCommand cmd = new MySqlCommand(sqlSelect, conn);
                cmd.Parameters.AddWithValue("@account", userAccount);
                MySqlDataReader dr = cmd.ExecuteReader();

                // 입력한 계정으로 등록된 정보가 있을 경우
                if (dr.HasRows)
                {
                    var text = "등록된 아이디가 있습니다. 다른 아이디를 입력해주세요.";
                    MessageBox.Show(text);
                    return;
                }

                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //conn.Close();
            }

            //
            // 아이디 중복 아니면 DB 등록
            //

            try
            {
                var sqlInsert = "INSERT INTO user ( id, account, password, name, created_at, deleted_at ) VALUES (@id, @account, @password, @name, @created_at, @deleted_at)";
                MySqlCommand cmd = new MySqlCommand(sqlInsert, conn);

                cmd.Parameters.AddWithValue("@id", Guid.NewGuid().ToString());
                cmd.Parameters.AddWithValue("@account", userAccount);
                cmd.Parameters.AddWithValue("@password", userPassword);
                cmd.Parameters.AddWithValue("@name", userName);
                cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                cmd.Parameters.AddWithValue("@deleted_at", null);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
                var text = "계정이 등록되었습니다.";
                MessageBox.Show(text);
                SetDefaultValue();
            }
        }

        //
        // 유저 삭제 버튼
        //
        private void UserDelete_Button_Click(object sender, EventArgs e)
        {
            //
            // 유저 선택 했는지 확인
            //
            if (selectedUserId == "")
            {
                var text = "삭제할 계정을 선택해주세요.";
                MessageBox.Show(text);
                return;
            }

            //
            // 로그인한 계정을 사용자 목록에서 지울 수 없도록 확인
            //
            if(selectedUserId.Equals(MainForm.currentUserId))
            {
                var text = "로그인한 계정을 삭제할 수 없습니다. 다른 계정을 선택해주세요.";
                MessageBox.Show(text);
                return;
            }

            if (MessageBox.Show("선택한 계정을 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                conn.Open();

                // 선택한 제품의 품번으로 DB에서 검색                
                var sqlSelect = "SELECT * FROM user WHERE id = @id and deleted_at is null;";
                MySqlCommand cmd = new MySqlCommand(sqlSelect, conn);
                cmd.Parameters.AddWithValue("@id", selectedUserId);
                MySqlDataReader dr = cmd.ExecuteReader();

                // 제품 있을 경우에 삭제 실행
                if (dr.HasRows)
                {
                    dr.Close();
                    var sqlUpdate = "UPDATE user SET deleted_at = @deleted_at WHERE id = @id;";
                    cmd = new MySqlCommand(sqlUpdate, conn);
                    cmd.Parameters.AddWithValue("@id", selectedUserId);
                    cmd.Parameters.AddWithValue("@deleted_at", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                var text = "DB 저장에 오류가 발생했습니다.";
                MessageBox.Show(text);
            }
            finally
            {
                var text = "계정이 삭제되었습니다.";
                MessageBox.Show(text);
                conn.Close();
                SetDefaultValue();
            }
        }

        //
        // 데이터 선택 시 이벤트 처리
        //
        private void UserList_Datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            // 선택한 셀의 id로 이벤트 처리
            //
            if (UserList_Datagridview.SelectedCells[0] == null)
            {
                selectedUserId = "";
                return;
            }

            if (UserList_Datagridview.SelectedCells[0].Value.ToString().Equals("") || UserList_Datagridview.SelectedCells[0].Value.ToString() == null)
            {
                selectedUserId = "";
                return;
            }

            selectedUserId = UserList_Datagridview.SelectedCells[0].Value.ToString();
        }
    }
}
