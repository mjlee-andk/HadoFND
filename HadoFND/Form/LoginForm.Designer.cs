namespace HadoFND
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.LoginAccount_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.LoginPassword_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.LoginOk_Button = new MetroFramework.Controls.MetroButton();
            this.LoginClose_Button = new MetroFramework.Controls.MetroButton();
            this.SaveID_CheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(373, 297);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(306, 175);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginAccount_TextBox
            // 
            // 
            // 
            // 
            this.LoginAccount_TextBox.CustomButton.Image = null;
            this.LoginAccount_TextBox.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.LoginAccount_TextBox.CustomButton.Name = "";
            this.LoginAccount_TextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.LoginAccount_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LoginAccount_TextBox.CustomButton.TabIndex = 1;
            this.LoginAccount_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LoginAccount_TextBox.CustomButton.UseSelectable = true;
            this.LoginAccount_TextBox.CustomButton.Visible = false;
            this.LoginAccount_TextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.LoginAccount_TextBox.Lines = new string[0];
            this.LoginAccount_TextBox.Location = new System.Drawing.Point(59, 144);
            this.LoginAccount_TextBox.MaxLength = 32767;
            this.LoginAccount_TextBox.Name = "LoginAccount_TextBox";
            this.LoginAccount_TextBox.PasswordChar = '\0';
            this.LoginAccount_TextBox.PromptText = "아이디";
            this.LoginAccount_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LoginAccount_TextBox.SelectedText = "";
            this.LoginAccount_TextBox.SelectionLength = 0;
            this.LoginAccount_TextBox.SelectionStart = 0;
            this.LoginAccount_TextBox.ShortcutsEnabled = true;
            this.LoginAccount_TextBox.Size = new System.Drawing.Size(167, 33);
            this.LoginAccount_TextBox.TabIndex = 4;
            this.LoginAccount_TextBox.UseSelectable = true;
            this.LoginAccount_TextBox.WaterMark = "아이디";
            this.LoginAccount_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LoginAccount_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // LoginPassword_TextBox
            // 
            // 
            // 
            // 
            this.LoginPassword_TextBox.CustomButton.Image = null;
            this.LoginPassword_TextBox.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.LoginPassword_TextBox.CustomButton.Name = "";
            this.LoginPassword_TextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.LoginPassword_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LoginPassword_TextBox.CustomButton.TabIndex = 1;
            this.LoginPassword_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LoginPassword_TextBox.CustomButton.UseSelectable = true;
            this.LoginPassword_TextBox.CustomButton.Visible = false;
            this.LoginPassword_TextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.LoginPassword_TextBox.Lines = new string[0];
            this.LoginPassword_TextBox.Location = new System.Drawing.Point(59, 183);
            this.LoginPassword_TextBox.MaxLength = 32767;
            this.LoginPassword_TextBox.Name = "LoginPassword_TextBox";
            this.LoginPassword_TextBox.PasswordChar = '*';
            this.LoginPassword_TextBox.PromptText = "비밀번호";
            this.LoginPassword_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LoginPassword_TextBox.SelectedText = "";
            this.LoginPassword_TextBox.SelectionLength = 0;
            this.LoginPassword_TextBox.SelectionStart = 0;
            this.LoginPassword_TextBox.ShortcutsEnabled = true;
            this.LoginPassword_TextBox.Size = new System.Drawing.Size(167, 33);
            this.LoginPassword_TextBox.TabIndex = 5;
            this.LoginPassword_TextBox.UseSelectable = true;
            this.LoginPassword_TextBox.WaterMark = "비밀번호";
            this.LoginPassword_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LoginPassword_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // LoginOk_Button
            // 
            this.LoginOk_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.LoginOk_Button.Location = new System.Drawing.Point(59, 294);
            this.LoginOk_Button.Name = "LoginOk_Button";
            this.LoginOk_Button.Size = new System.Drawing.Size(167, 33);
            this.LoginOk_Button.TabIndex = 7;
            this.LoginOk_Button.Text = "로그인";
            this.LoginOk_Button.UseSelectable = true;
            this.LoginOk_Button.Click += new System.EventHandler(this.login_button_click);
            // 
            // LoginClose_Button
            // 
            this.LoginClose_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.LoginClose_Button.Location = new System.Drawing.Point(59, 333);
            this.LoginClose_Button.Name = "LoginClose_Button";
            this.LoginClose_Button.Size = new System.Drawing.Size(167, 33);
            this.LoginClose_Button.TabIndex = 8;
            this.LoginClose_Button.Text = "종료";
            this.LoginClose_Button.UseSelectable = true;
            this.LoginClose_Button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // SaveID_CheckBox
            // 
            this.SaveID_CheckBox.AutoSize = true;
            this.SaveID_CheckBox.Location = new System.Drawing.Point(59, 232);
            this.SaveID_CheckBox.Name = "SaveID_CheckBox";
            this.SaveID_CheckBox.Size = new System.Drawing.Size(86, 15);
            this.SaveID_CheckBox.TabIndex = 9;
            this.SaveID_CheckBox.Text = "아이디 저장";
            this.SaveID_CheckBox.UseSelectable = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginOk_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.ControlBox = false;
            this.Controls.Add(this.SaveID_CheckBox);
            this.Controls.Add(this.LoginClose_Button);
            this.Controls.Add(this.LoginOk_Button);
            this.Controls.Add(this.LoginPassword_TextBox);
            this.Controls.Add(this.LoginAccount_TextBox);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroButton1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "하도FND";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox LoginAccount_TextBox;
        private MetroFramework.Controls.MetroTextBox LoginPassword_TextBox;
        private MetroFramework.Controls.MetroButton LoginOk_Button;
        private MetroFramework.Controls.MetroButton LoginClose_Button;
        private MetroFramework.Controls.MetroCheckBox SaveID_CheckBox;
    }
}

