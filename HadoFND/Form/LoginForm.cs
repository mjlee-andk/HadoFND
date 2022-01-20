using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HadoFND
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm // 상속 클래스 변경
    {
        ConfigFile _configFile = new ConfigFile();
        
        MySqlConnection conn;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            // 환경설정 파일 로드
            //
            _configFile = _configFile.Load();

            string connectString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};", _configFile.Db_IP, _configFile.Db_NAME, _configFile.Db_ID, _configFile.Db_PW);
            conn = new MySqlConnection(connectString);

            this.Activate();

            LoginAccount_TextBox.Text = Properties.Settings.Default.LoginIDSave;

            // 아이디 저장이 체크되어 있으면
            if (Properties.Settings.Default.LoginIDSaveChecked)
            {
                SaveID_CheckBox.Checked = true;
                // 로그인 폼으로 포커싱 주고 비밀번호 입력창에 포커싱
                this.ActiveControl = LoginPassword_TextBox;
                LoginPassword_TextBox.Focus();
            }
            else
            {
                SaveID_CheckBox.Checked = false;
                // 로그인 폼으로 포커싱 주고 아이디 입력창에 포커싱
                this.ActiveControl = LoginAccount_TextBox;
                LoginAccount_TextBox.Focus();
            }
        }
        
        private void login_button_click(object sender, EventArgs e)
        {
            var user_account = LoginAccount_TextBox.Text;   // 사용자 아이디
            var user_password = LoginPassword_TextBox.Text; // 사용자 비밀번호

            // 아이디, 패스워드 입력했는지 확인
            if (user_account.Equals("") || user_account == null)
            {
                var text = "아이디를 입력해주세요";
                MessageBox.Show(text);
                return;
            }

            if (user_password.Equals("") || user_password == null)
            {
                var text = "비밀번호를 입력해주세요";
                MessageBox.Show(text);
                return;
            }

            var user_id = "";
            // DB에 등록된 계정인지 확인
            try
            {
                conn.Open();

                var sqlSelect = "SELECT * FROM user WHERE account = @account AND deleted_at is null;";
                

                MySqlCommand cmd = new MySqlCommand(sqlSelect, conn);
                cmd.Parameters.AddWithValue("@account", user_account);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (!dr.HasRows)
                {
                    var text = "등록되지 않은 계정입니다. 아이디를 확인해주세요.";
                    MessageBox.Show(text);
                    conn.Close();
                }
                else
                {
                    dr.Read();

                    user_id = dr["id"].ToString();

                    // 비밀번호 일치하면 메인화면으로 이동
                    if (!user_password.Equals(dr["password"].ToString()))
                    {
                        var text = "비밀번호가 맞지 않습니다.";
                        MessageBox.Show(text);
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        /*
                         * 아이디 저장 체크 시
                         */
                        if (SaveID_CheckBox.Checked)
                        {
                            Properties.Settings.Default.LoginIDSave = LoginAccount_TextBox.Text;
                            Properties.Settings.Default.LoginIDSaveChecked = true;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.LoginIDSave = "";
                            Properties.Settings.Default.LoginIDSaveChecked = false;
                            Properties.Settings.Default.Save();
                        }

                        /*
                        로그인 성공 시 로그인 폼 숨겨두고
                        메인 폼 띄운다. 메인 폼 종료 시 로그인 폼의 this.Close()가 실행된다.
                         */
                        this.Hide();
                        MainForm.currentUserId = user_id;
                        MainForm mainForm = new MainForm();
                        mainForm.ShowDialog();
                        this.Close();
                    }                    
                }

                
            }
            catch (Exception ex)
            {
                Util.LogFile(ex.Message, ex.ToString(), "", 0, this.FindForm().Name);
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Util.CloseCurrentFormMessageBox(this);
        }
    }
}
