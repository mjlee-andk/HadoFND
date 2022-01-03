namespace HadoFND
{
    partial class UserManageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserDelete_Button = new MetroFramework.Controls.MetroButton();
            this.UserList_Label = new MetroFramework.Controls.MetroLabel();
            this.UserAdd_Button = new MetroFramework.Controls.MetroButton();
            this.UserPassword_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.UserPassword_Label = new MetroFramework.Controls.MetroLabel();
            this.UserAccount_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.UserAccount_Label = new MetroFramework.Controls.MetroLabel();
            this.UserName_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.UserName_Label = new MetroFramework.Controls.MetroLabel();
            this.UserList_Datagridview = new MetroFramework.Controls.MetroGrid();
            this.UserPasswordConfirm_Label = new MetroFramework.Controls.MetroLabel();
            this.UserPasswordConfirm_TextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserList_Datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDelete_Button
            // 
            this.UserDelete_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.UserDelete_Button.Location = new System.Drawing.Point(378, 369);
            this.UserDelete_Button.Name = "UserDelete_Button";
            this.UserDelete_Button.Size = new System.Drawing.Size(293, 56);
            this.UserDelete_Button.TabIndex = 19;
            this.UserDelete_Button.Text = "삭제";
            this.UserDelete_Button.UseSelectable = true;
            this.UserDelete_Button.Click += new System.EventHandler(this.UserDelete_Button_Click);
            // 
            // UserList_Label
            // 
            this.UserList_Label.AutoSize = true;
            this.UserList_Label.Location = new System.Drawing.Point(23, 93);
            this.UserList_Label.Name = "UserList_Label";
            this.UserList_Label.Size = new System.Drawing.Size(69, 19);
            this.UserList_Label.TabIndex = 18;
            this.UserList_Label.Text = "유저 목록";
            // 
            // UserAdd_Button
            // 
            this.UserAdd_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.UserAdd_Button.Location = new System.Drawing.Point(378, 297);
            this.UserAdd_Button.Name = "UserAdd_Button";
            this.UserAdd_Button.Size = new System.Drawing.Size(293, 55);
            this.UserAdd_Button.TabIndex = 17;
            this.UserAdd_Button.Text = "등록";
            this.UserAdd_Button.UseSelectable = true;
            this.UserAdd_Button.Click += new System.EventHandler(this.UserAdd_Button_Click);
            // 
            // UserPassword_TextBox
            // 
            // 
            // 
            // 
            this.UserPassword_TextBox.CustomButton.Image = null;
            this.UserPassword_TextBox.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.UserPassword_TextBox.CustomButton.Name = "";
            this.UserPassword_TextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.UserPassword_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserPassword_TextBox.CustomButton.TabIndex = 1;
            this.UserPassword_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserPassword_TextBox.CustomButton.UseSelectable = true;
            this.UserPassword_TextBox.CustomButton.Visible = false;
            this.UserPassword_TextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.UserPassword_TextBox.Lines = new string[0];
            this.UserPassword_TextBox.Location = new System.Drawing.Point(507, 208);
            this.UserPassword_TextBox.MaxLength = 32767;
            this.UserPassword_TextBox.Name = "UserPassword_TextBox";
            this.UserPassword_TextBox.PasswordChar = '*';
            this.UserPassword_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserPassword_TextBox.SelectedText = "";
            this.UserPassword_TextBox.SelectionLength = 0;
            this.UserPassword_TextBox.SelectionStart = 0;
            this.UserPassword_TextBox.ShortcutsEnabled = true;
            this.UserPassword_TextBox.Size = new System.Drawing.Size(164, 33);
            this.UserPassword_TextBox.TabIndex = 16;
            this.UserPassword_TextBox.UseSelectable = true;
            this.UserPassword_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserPassword_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UserPassword_Label
            // 
            this.UserPassword_Label.AutoSize = true;
            this.UserPassword_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UserPassword_Label.Location = new System.Drawing.Point(378, 207);
            this.UserPassword_Label.Name = "UserPassword_Label";
            this.UserPassword_Label.Size = new System.Drawing.Size(84, 25);
            this.UserPassword_Label.TabIndex = 15;
            this.UserPassword_Label.Text = "비밀번호";
            // 
            // UserAccount_TextBox
            // 
            // 
            // 
            // 
            this.UserAccount_TextBox.CustomButton.Image = null;
            this.UserAccount_TextBox.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.UserAccount_TextBox.CustomButton.Name = "";
            this.UserAccount_TextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.UserAccount_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserAccount_TextBox.CustomButton.TabIndex = 1;
            this.UserAccount_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserAccount_TextBox.CustomButton.UseSelectable = true;
            this.UserAccount_TextBox.CustomButton.Visible = false;
            this.UserAccount_TextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.UserAccount_TextBox.Lines = new string[0];
            this.UserAccount_TextBox.Location = new System.Drawing.Point(507, 168);
            this.UserAccount_TextBox.MaxLength = 32767;
            this.UserAccount_TextBox.Name = "UserAccount_TextBox";
            this.UserAccount_TextBox.PasswordChar = '\0';
            this.UserAccount_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserAccount_TextBox.SelectedText = "";
            this.UserAccount_TextBox.SelectionLength = 0;
            this.UserAccount_TextBox.SelectionStart = 0;
            this.UserAccount_TextBox.ShortcutsEnabled = true;
            this.UserAccount_TextBox.Size = new System.Drawing.Size(164, 33);
            this.UserAccount_TextBox.TabIndex = 14;
            this.UserAccount_TextBox.UseSelectable = true;
            this.UserAccount_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserAccount_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UserAccount_Label
            // 
            this.UserAccount_Label.AutoSize = true;
            this.UserAccount_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UserAccount_Label.Location = new System.Drawing.Point(378, 166);
            this.UserAccount_Label.Name = "UserAccount_Label";
            this.UserAccount_Label.Size = new System.Drawing.Size(66, 25);
            this.UserAccount_Label.TabIndex = 13;
            this.UserAccount_Label.Text = "아이디";
            // 
            // UserName_TextBox
            // 
            // 
            // 
            // 
            this.UserName_TextBox.CustomButton.Image = null;
            this.UserName_TextBox.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.UserName_TextBox.CustomButton.Name = "";
            this.UserName_TextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.UserName_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserName_TextBox.CustomButton.TabIndex = 1;
            this.UserName_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserName_TextBox.CustomButton.UseSelectable = true;
            this.UserName_TextBox.CustomButton.Visible = false;
            this.UserName_TextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.UserName_TextBox.Lines = new string[0];
            this.UserName_TextBox.Location = new System.Drawing.Point(507, 129);
            this.UserName_TextBox.MaxLength = 32767;
            this.UserName_TextBox.Name = "UserName_TextBox";
            this.UserName_TextBox.PasswordChar = '\0';
            this.UserName_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserName_TextBox.SelectedText = "";
            this.UserName_TextBox.SelectionLength = 0;
            this.UserName_TextBox.SelectionStart = 0;
            this.UserName_TextBox.ShortcutsEnabled = true;
            this.UserName_TextBox.Size = new System.Drawing.Size(164, 33);
            this.UserName_TextBox.TabIndex = 12;
            this.UserName_TextBox.UseSelectable = true;
            this.UserName_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserName_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UserName_Label
            // 
            this.UserName_Label.AutoSize = true;
            this.UserName_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UserName_Label.Location = new System.Drawing.Point(378, 125);
            this.UserName_Label.Name = "UserName_Label";
            this.UserName_Label.Size = new System.Drawing.Size(48, 25);
            this.UserName_Label.TabIndex = 11;
            this.UserName_Label.Text = "이름";
            // 
            // UserList_Datagridview
            // 
            this.UserList_Datagridview.AllowUserToAddRows = false;
            this.UserList_Datagridview.AllowUserToDeleteRows = false;
            this.UserList_Datagridview.AllowUserToResizeColumns = false;
            this.UserList_Datagridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UserList_Datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserList_Datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserList_Datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.UserList_Datagridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UserList_Datagridview.BackgroundColor = System.Drawing.Color.Silver;
            this.UserList_Datagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UserList_Datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserList_Datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserList_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserList_Datagridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserList_Datagridview.EnableHeadersVisualStyles = false;
            this.UserList_Datagridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserList_Datagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserList_Datagridview.Location = new System.Drawing.Point(23, 127);
            this.UserList_Datagridview.Name = "UserList_Datagridview";
            this.UserList_Datagridview.ReadOnly = true;
            this.UserList_Datagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserList_Datagridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UserList_Datagridview.RowHeadersWidth = 40;
            this.UserList_Datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            this.UserList_Datagridview.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.UserList_Datagridview.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UserList_Datagridview.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserList_Datagridview.RowTemplate.Height = 23;
            this.UserList_Datagridview.RowTemplate.ReadOnly = true;
            this.UserList_Datagridview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserList_Datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserList_Datagridview.Size = new System.Drawing.Size(316, 300);
            this.UserList_Datagridview.TabIndex = 20;
            this.UserList_Datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserList_Datagridview_CellClick);
            // 
            // UserPasswordConfirm_Label
            // 
            this.UserPasswordConfirm_Label.AutoSize = true;
            this.UserPasswordConfirm_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UserPasswordConfirm_Label.Location = new System.Drawing.Point(378, 251);
            this.UserPasswordConfirm_Label.Name = "UserPasswordConfirm_Label";
            this.UserPasswordConfirm_Label.Size = new System.Drawing.Size(125, 25);
            this.UserPasswordConfirm_Label.TabIndex = 21;
            this.UserPasswordConfirm_Label.Text = "비밀번호 확인";
            // 
            // UserPasswordConfirm_TextBox
            // 
            // 
            // 
            // 
            this.UserPasswordConfirm_TextBox.CustomButton.Image = null;
            this.UserPasswordConfirm_TextBox.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.UserPasswordConfirm_TextBox.CustomButton.Name = "";
            this.UserPasswordConfirm_TextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.UserPasswordConfirm_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserPasswordConfirm_TextBox.CustomButton.TabIndex = 1;
            this.UserPasswordConfirm_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserPasswordConfirm_TextBox.CustomButton.UseSelectable = true;
            this.UserPasswordConfirm_TextBox.CustomButton.Visible = false;
            this.UserPasswordConfirm_TextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.UserPasswordConfirm_TextBox.Lines = new string[0];
            this.UserPasswordConfirm_TextBox.Location = new System.Drawing.Point(507, 249);
            this.UserPasswordConfirm_TextBox.MaxLength = 32767;
            this.UserPasswordConfirm_TextBox.Name = "UserPasswordConfirm_TextBox";
            this.UserPasswordConfirm_TextBox.PasswordChar = '*';
            this.UserPasswordConfirm_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserPasswordConfirm_TextBox.SelectedText = "";
            this.UserPasswordConfirm_TextBox.SelectionLength = 0;
            this.UserPasswordConfirm_TextBox.SelectionStart = 0;
            this.UserPasswordConfirm_TextBox.ShortcutsEnabled = true;
            this.UserPasswordConfirm_TextBox.Size = new System.Drawing.Size(164, 33);
            this.UserPasswordConfirm_TextBox.TabIndex = 22;
            this.UserPasswordConfirm_TextBox.UseSelectable = true;
            this.UserPasswordConfirm_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserPasswordConfirm_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UserManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.UserPasswordConfirm_TextBox);
            this.Controls.Add(this.UserPasswordConfirm_Label);
            this.Controls.Add(this.UserList_Datagridview);
            this.Controls.Add(this.UserDelete_Button);
            this.Controls.Add(this.UserList_Label);
            this.Controls.Add(this.UserAdd_Button);
            this.Controls.Add(this.UserPassword_TextBox);
            this.Controls.Add(this.UserPassword_Label);
            this.Controls.Add(this.UserAccount_TextBox);
            this.Controls.Add(this.UserAccount_Label);
            this.Controls.Add(this.UserName_TextBox);
            this.Controls.Add(this.UserName_Label);
            this.Name = "UserManageForm";
            this.Text = "유저 관리";
            this.Load += new System.EventHandler(this.UserManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserList_Datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton UserDelete_Button;
        private MetroFramework.Controls.MetroLabel UserList_Label;
        private MetroFramework.Controls.MetroButton UserAdd_Button;
        private MetroFramework.Controls.MetroTextBox UserPassword_TextBox;
        private MetroFramework.Controls.MetroLabel UserPassword_Label;
        private MetroFramework.Controls.MetroTextBox UserAccount_TextBox;
        private MetroFramework.Controls.MetroLabel UserAccount_Label;
        private MetroFramework.Controls.MetroTextBox UserName_TextBox;
        private MetroFramework.Controls.MetroLabel UserName_Label;
        private MetroFramework.Controls.MetroGrid UserList_Datagridview;
        private MetroFramework.Controls.MetroLabel UserPasswordConfirm_Label;
        private MetroFramework.Controls.MetroTextBox UserPasswordConfirm_TextBox;
    }
}