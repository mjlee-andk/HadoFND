namespace HadoFND
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SerialSetting_Button = new MetroFramework.Controls.MetroButton();
            this.ExcelExport_Button = new MetroFramework.Controls.MetroButton();
            this.ProductManage_Button = new MetroFramework.Controls.MetroButton();
            this.UserManage_Button = new MetroFramework.Controls.MetroButton();
            this.WorkStart_Button = new MetroFramework.Controls.MetroButton();
            this.WorkEnd_Button = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.ScaleValue_Textbox = new MetroFramework.Controls.MetroTextBox();
            this.ScaleValue_Label = new MetroFramework.Controls.MetroLabel();
            this.Product_Name_Combobox = new MetroFramework.Controls.MetroComboBox();
            this.Lo_Textbox = new MetroFramework.Controls.MetroTextBox();
            this.Hi_Textbox = new MetroFramework.Controls.MetroTextBox();
            this.WorkCount_Textbox = new MetroFramework.Controls.MetroTextBox();
            this.WorkDate_Textbox = new MetroFramework.Controls.MetroTextBox();
            this.Hi_Label = new MetroFramework.Controls.MetroLabel();
            this.Lo_Label = new MetroFramework.Controls.MetroLabel();
            this.ProductName_Label = new MetroFramework.Controls.MetroLabel();
            this.WorkCount_Label = new MetroFramework.Controls.MetroLabel();
            this.WorkDate_Label = new MetroFramework.Controls.MetroLabel();
            this.Weight_Label = new MetroFramework.Controls.MetroLabel();
            this.TotalWeight_Label = new MetroFramework.Controls.MetroLabel();
            this.Weight_Textbox = new MetroFramework.Controls.MetroTextBox();
            this.TotalWeight_Textbox = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.LedCheck_Button = new MetroFramework.Controls.MetroButton();
            this.TodayWorkRecords_Datagridview = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TodayWorkRecords_Datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // SerialSetting_Button
            // 
            this.SerialSetting_Button.Location = new System.Drawing.Point(11, 11);
            this.SerialSetting_Button.Name = "SerialSetting_Button";
            this.SerialSetting_Button.Size = new System.Drawing.Size(75, 23);
            this.SerialSetting_Button.TabIndex = 0;
            this.SerialSetting_Button.Text = "통신설정";
            this.SerialSetting_Button.UseSelectable = true;
            this.SerialSetting_Button.Click += new System.EventHandler(this.SerialSetting_Button_Click);
            // 
            // ExcelExport_Button
            // 
            this.ExcelExport_Button.Location = new System.Drawing.Point(254, 11);
            this.ExcelExport_Button.Name = "ExcelExport_Button";
            this.ExcelExport_Button.Size = new System.Drawing.Size(75, 23);
            this.ExcelExport_Button.TabIndex = 1;
            this.ExcelExport_Button.Text = "작업기록관리";
            this.ExcelExport_Button.UseSelectable = true;
            this.ExcelExport_Button.Click += new System.EventHandler(this.ExcelExport_Button_Click);
            // 
            // ProductManage_Button
            // 
            this.ProductManage_Button.Location = new System.Drawing.Point(92, 11);
            this.ProductManage_Button.Name = "ProductManage_Button";
            this.ProductManage_Button.Size = new System.Drawing.Size(75, 23);
            this.ProductManage_Button.TabIndex = 2;
            this.ProductManage_Button.Text = "제품관리";
            this.ProductManage_Button.UseSelectable = true;
            this.ProductManage_Button.Click += new System.EventHandler(this.ProductManage_Button_Click);
            // 
            // UserManage_Button
            // 
            this.UserManage_Button.Location = new System.Drawing.Point(173, 11);
            this.UserManage_Button.Name = "UserManage_Button";
            this.UserManage_Button.Size = new System.Drawing.Size(75, 23);
            this.UserManage_Button.TabIndex = 3;
            this.UserManage_Button.Text = "유저관리";
            this.UserManage_Button.UseSelectable = true;
            this.UserManage_Button.Click += new System.EventHandler(this.UserManage_Button_Click);
            // 
            // WorkStart_Button
            // 
            this.WorkStart_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.WorkStart_Button.Location = new System.Drawing.Point(727, 39);
            this.WorkStart_Button.Name = "WorkStart_Button";
            this.WorkStart_Button.Size = new System.Drawing.Size(100, 50);
            this.WorkStart_Button.TabIndex = 4;
            this.WorkStart_Button.Text = "작업시작";
            this.WorkStart_Button.UseSelectable = true;
            this.WorkStart_Button.Click += new System.EventHandler(this.WorkStart_Button_Click);
            // 
            // WorkEnd_Button
            // 
            this.WorkEnd_Button.Enabled = false;
            this.WorkEnd_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.WorkEnd_Button.Location = new System.Drawing.Point(877, 39);
            this.WorkEnd_Button.Name = "WorkEnd_Button";
            this.WorkEnd_Button.Size = new System.Drawing.Size(100, 50);
            this.WorkEnd_Button.TabIndex = 5;
            this.WorkEnd_Button.Text = "작업종료";
            this.WorkEnd_Button.UseSelectable = true;
            this.WorkEnd_Button.Click += new System.EventHandler(this.WorkEnd_Button_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.ScaleValue_Textbox);
            this.metroPanel1.Controls.Add(this.ScaleValue_Label);
            this.metroPanel1.Controls.Add(this.Product_Name_Combobox);
            this.metroPanel1.Controls.Add(this.Lo_Textbox);
            this.metroPanel1.Controls.Add(this.Hi_Textbox);
            this.metroPanel1.Controls.Add(this.WorkCount_Textbox);
            this.metroPanel1.Controls.Add(this.WorkDate_Textbox);
            this.metroPanel1.Controls.Add(this.Hi_Label);
            this.metroPanel1.Controls.Add(this.Lo_Label);
            this.metroPanel1.Controls.Add(this.ProductName_Label);
            this.metroPanel1.Controls.Add(this.WorkCount_Label);
            this.metroPanel1.Controls.Add(this.WorkDate_Label);
            this.metroPanel1.Controls.Add(this.Weight_Label);
            this.metroPanel1.Controls.Add(this.TotalWeight_Label);
            this.metroPanel1.Controls.Add(this.Weight_Textbox);
            this.metroPanel1.Controls.Add(this.TotalWeight_Textbox);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(11, 40);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(689, 421);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ScaleValue_Textbox
            // 
            // 
            // 
            // 
            this.ScaleValue_Textbox.CustomButton.Image = null;
            this.ScaleValue_Textbox.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.ScaleValue_Textbox.CustomButton.Name = "";
            this.ScaleValue_Textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ScaleValue_Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ScaleValue_Textbox.CustomButton.TabIndex = 1;
            this.ScaleValue_Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ScaleValue_Textbox.CustomButton.UseSelectable = true;
            this.ScaleValue_Textbox.CustomButton.Visible = false;
            this.ScaleValue_Textbox.Lines = new string[] {
        "0"};
            this.ScaleValue_Textbox.Location = new System.Drawing.Point(141, 57);
            this.ScaleValue_Textbox.MaxLength = 32767;
            this.ScaleValue_Textbox.Name = "ScaleValue_Textbox";
            this.ScaleValue_Textbox.PasswordChar = '\0';
            this.ScaleValue_Textbox.ReadOnly = true;
            this.ScaleValue_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ScaleValue_Textbox.SelectedText = "";
            this.ScaleValue_Textbox.SelectionLength = 0;
            this.ScaleValue_Textbox.SelectionStart = 0;
            this.ScaleValue_Textbox.ShortcutsEnabled = true;
            this.ScaleValue_Textbox.Size = new System.Drawing.Size(143, 23);
            this.ScaleValue_Textbox.TabIndex = 18;
            this.ScaleValue_Textbox.Text = "0";
            this.ScaleValue_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScaleValue_Textbox.UseSelectable = true;
            this.ScaleValue_Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ScaleValue_Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ScaleValue_Label
            // 
            this.ScaleValue_Label.AutoSize = true;
            this.ScaleValue_Label.Location = new System.Drawing.Point(12, 57);
            this.ScaleValue_Label.Name = "ScaleValue_Label";
            this.ScaleValue_Label.Size = new System.Drawing.Size(83, 19);
            this.ScaleValue_Label.TabIndex = 17;
            this.ScaleValue_Label.Text = "저울 계량값";
            // 
            // Product_Name_Combobox
            // 
            this.Product_Name_Combobox.FormattingEnabled = true;
            this.Product_Name_Combobox.ItemHeight = 23;
            this.Product_Name_Combobox.Location = new System.Drawing.Point(141, 199);
            this.Product_Name_Combobox.Name = "Product_Name_Combobox";
            this.Product_Name_Combobox.Size = new System.Drawing.Size(143, 29);
            this.Product_Name_Combobox.TabIndex = 16;
            this.Product_Name_Combobox.UseSelectable = true;
            this.Product_Name_Combobox.SelectedIndexChanged += new System.EventHandler(this.Product_Name_Combobox_SelectedIndexChanged);
            // 
            // Lo_Textbox
            // 
            // 
            // 
            // 
            this.Lo_Textbox.CustomButton.Image = null;
            this.Lo_Textbox.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.Lo_Textbox.CustomButton.Name = "";
            this.Lo_Textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Lo_Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Lo_Textbox.CustomButton.TabIndex = 1;
            this.Lo_Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Lo_Textbox.CustomButton.UseSelectable = true;
            this.Lo_Textbox.CustomButton.Visible = false;
            this.Lo_Textbox.Lines = new string[] {
        "0"};
            this.Lo_Textbox.Location = new System.Drawing.Point(141, 270);
            this.Lo_Textbox.MaxLength = 32767;
            this.Lo_Textbox.Name = "Lo_Textbox";
            this.Lo_Textbox.PasswordChar = '\0';
            this.Lo_Textbox.ReadOnly = true;
            this.Lo_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Lo_Textbox.SelectedText = "";
            this.Lo_Textbox.SelectionLength = 0;
            this.Lo_Textbox.SelectionStart = 0;
            this.Lo_Textbox.ShortcutsEnabled = true;
            this.Lo_Textbox.Size = new System.Drawing.Size(143, 23);
            this.Lo_Textbox.TabIndex = 15;
            this.Lo_Textbox.Text = "0";
            this.Lo_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Lo_Textbox.UseSelectable = true;
            this.Lo_Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lo_Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Hi_Textbox
            // 
            // 
            // 
            // 
            this.Hi_Textbox.CustomButton.Image = null;
            this.Hi_Textbox.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.Hi_Textbox.CustomButton.Name = "";
            this.Hi_Textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Hi_Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Hi_Textbox.CustomButton.TabIndex = 1;
            this.Hi_Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Hi_Textbox.CustomButton.UseSelectable = true;
            this.Hi_Textbox.CustomButton.Visible = false;
            this.Hi_Textbox.Lines = new string[] {
        "0"};
            this.Hi_Textbox.Location = new System.Drawing.Point(141, 235);
            this.Hi_Textbox.MaxLength = 32767;
            this.Hi_Textbox.Name = "Hi_Textbox";
            this.Hi_Textbox.PasswordChar = '\0';
            this.Hi_Textbox.ReadOnly = true;
            this.Hi_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Hi_Textbox.SelectedText = "";
            this.Hi_Textbox.SelectionLength = 0;
            this.Hi_Textbox.SelectionStart = 0;
            this.Hi_Textbox.ShortcutsEnabled = true;
            this.Hi_Textbox.Size = new System.Drawing.Size(143, 23);
            this.Hi_Textbox.TabIndex = 14;
            this.Hi_Textbox.Text = "0";
            this.Hi_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hi_Textbox.UseSelectable = true;
            this.Hi_Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Hi_Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // WorkCount_Textbox
            // 
            // 
            // 
            // 
            this.WorkCount_Textbox.CustomButton.Image = null;
            this.WorkCount_Textbox.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.WorkCount_Textbox.CustomButton.Name = "";
            this.WorkCount_Textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.WorkCount_Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.WorkCount_Textbox.CustomButton.TabIndex = 1;
            this.WorkCount_Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WorkCount_Textbox.CustomButton.UseSelectable = true;
            this.WorkCount_Textbox.CustomButton.Visible = false;
            this.WorkCount_Textbox.Lines = new string[] {
        "0"};
            this.WorkCount_Textbox.Location = new System.Drawing.Point(141, 170);
            this.WorkCount_Textbox.MaxLength = 32767;
            this.WorkCount_Textbox.Name = "WorkCount_Textbox";
            this.WorkCount_Textbox.PasswordChar = '\0';
            this.WorkCount_Textbox.ReadOnly = true;
            this.WorkCount_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WorkCount_Textbox.SelectedText = "";
            this.WorkCount_Textbox.SelectionLength = 0;
            this.WorkCount_Textbox.SelectionStart = 0;
            this.WorkCount_Textbox.ShortcutsEnabled = true;
            this.WorkCount_Textbox.Size = new System.Drawing.Size(143, 23);
            this.WorkCount_Textbox.TabIndex = 12;
            this.WorkCount_Textbox.Text = "0";
            this.WorkCount_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WorkCount_Textbox.UseSelectable = true;
            this.WorkCount_Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WorkCount_Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // WorkDate_Textbox
            // 
            // 
            // 
            // 
            this.WorkDate_Textbox.CustomButton.Image = null;
            this.WorkDate_Textbox.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.WorkDate_Textbox.CustomButton.Name = "";
            this.WorkDate_Textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.WorkDate_Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.WorkDate_Textbox.CustomButton.TabIndex = 1;
            this.WorkDate_Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WorkDate_Textbox.CustomButton.UseSelectable = true;
            this.WorkDate_Textbox.CustomButton.Visible = false;
            this.WorkDate_Textbox.Lines = new string[0];
            this.WorkDate_Textbox.Location = new System.Drawing.Point(141, 134);
            this.WorkDate_Textbox.MaxLength = 32767;
            this.WorkDate_Textbox.Name = "WorkDate_Textbox";
            this.WorkDate_Textbox.PasswordChar = '\0';
            this.WorkDate_Textbox.ReadOnly = true;
            this.WorkDate_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WorkDate_Textbox.SelectedText = "";
            this.WorkDate_Textbox.SelectionLength = 0;
            this.WorkDate_Textbox.SelectionStart = 0;
            this.WorkDate_Textbox.ShortcutsEnabled = true;
            this.WorkDate_Textbox.Size = new System.Drawing.Size(143, 23);
            this.WorkDate_Textbox.TabIndex = 11;
            this.WorkDate_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WorkDate_Textbox.UseSelectable = true;
            this.WorkDate_Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WorkDate_Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Hi_Label
            // 
            this.Hi_Label.AutoSize = true;
            this.Hi_Label.Location = new System.Drawing.Point(12, 235);
            this.Hi_Label.Name = "Hi_Label";
            this.Hi_Label.Size = new System.Drawing.Size(37, 19);
            this.Hi_Label.TabIndex = 10;
            this.Hi_Label.Text = "상한";
            // 
            // Lo_Label
            // 
            this.Lo_Label.AutoSize = true;
            this.Lo_Label.Location = new System.Drawing.Point(12, 270);
            this.Lo_Label.Name = "Lo_Label";
            this.Lo_Label.Size = new System.Drawing.Size(37, 19);
            this.Lo_Label.TabIndex = 9;
            this.Lo_Label.Text = "하한";
            // 
            // ProductName_Label
            // 
            this.ProductName_Label.AutoSize = true;
            this.ProductName_Label.Location = new System.Drawing.Point(12, 203);
            this.ProductName_Label.Name = "ProductName_Label";
            this.ProductName_Label.Size = new System.Drawing.Size(51, 19);
            this.ProductName_Label.TabIndex = 8;
            this.ProductName_Label.Text = "제품명";
            // 
            // WorkCount_Label
            // 
            this.WorkCount_Label.AutoSize = true;
            this.WorkCount_Label.Location = new System.Drawing.Point(12, 170);
            this.WorkCount_Label.Name = "WorkCount_Label";
            this.WorkCount_Label.Size = new System.Drawing.Size(51, 19);
            this.WorkCount_Label.TabIndex = 7;
            this.WorkCount_Label.Text = "작업수";
            // 
            // WorkDate_Label
            // 
            this.WorkDate_Label.AutoSize = true;
            this.WorkDate_Label.Location = new System.Drawing.Point(12, 138);
            this.WorkDate_Label.Name = "WorkDate_Label";
            this.WorkDate_Label.Size = new System.Drawing.Size(65, 19);
            this.WorkDate_Label.TabIndex = 6;
            this.WorkDate_Label.Text = "작업일자";
            // 
            // Weight_Label
            // 
            this.Weight_Label.AutoSize = true;
            this.Weight_Label.Location = new System.Drawing.Point(12, 90);
            this.Weight_Label.Name = "Weight_Label";
            this.Weight_Label.Size = new System.Drawing.Size(69, 19);
            this.Weight_Label.TabIndex = 5;
            this.Weight_Label.Text = "추가 중량";
            // 
            // TotalWeight_Label
            // 
            this.TotalWeight_Label.AutoSize = true;
            this.TotalWeight_Label.Location = new System.Drawing.Point(12, 23);
            this.TotalWeight_Label.Name = "TotalWeight_Label";
            this.TotalWeight_Label.Size = new System.Drawing.Size(87, 19);
            this.TotalWeight_Label.TabIndex = 4;
            this.TotalWeight_Label.Text = "총 작업 중량";
            // 
            // Weight_Textbox
            // 
            // 
            // 
            // 
            this.Weight_Textbox.CustomButton.Image = null;
            this.Weight_Textbox.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.Weight_Textbox.CustomButton.Name = "";
            this.Weight_Textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Weight_Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Weight_Textbox.CustomButton.TabIndex = 1;
            this.Weight_Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Weight_Textbox.CustomButton.UseSelectable = true;
            this.Weight_Textbox.CustomButton.Visible = false;
            this.Weight_Textbox.Lines = new string[] {
        "0"};
            this.Weight_Textbox.Location = new System.Drawing.Point(141, 90);
            this.Weight_Textbox.MaxLength = 32767;
            this.Weight_Textbox.Name = "Weight_Textbox";
            this.Weight_Textbox.PasswordChar = '\0';
            this.Weight_Textbox.ReadOnly = true;
            this.Weight_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Weight_Textbox.SelectedText = "";
            this.Weight_Textbox.SelectionLength = 0;
            this.Weight_Textbox.SelectionStart = 0;
            this.Weight_Textbox.ShortcutsEnabled = true;
            this.Weight_Textbox.Size = new System.Drawing.Size(143, 23);
            this.Weight_Textbox.TabIndex = 3;
            this.Weight_Textbox.Text = "0";
            this.Weight_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Weight_Textbox.UseSelectable = true;
            this.Weight_Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Weight_Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TotalWeight_Textbox
            // 
            // 
            // 
            // 
            this.TotalWeight_Textbox.CustomButton.Image = null;
            this.TotalWeight_Textbox.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.TotalWeight_Textbox.CustomButton.Name = "";
            this.TotalWeight_Textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TotalWeight_Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TotalWeight_Textbox.CustomButton.TabIndex = 1;
            this.TotalWeight_Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TotalWeight_Textbox.CustomButton.UseSelectable = true;
            this.TotalWeight_Textbox.CustomButton.Visible = false;
            this.TotalWeight_Textbox.Lines = new string[] {
        "0"};
            this.TotalWeight_Textbox.Location = new System.Drawing.Point(141, 23);
            this.TotalWeight_Textbox.MaxLength = 32767;
            this.TotalWeight_Textbox.Name = "TotalWeight_Textbox";
            this.TotalWeight_Textbox.PasswordChar = '\0';
            this.TotalWeight_Textbox.ReadOnly = true;
            this.TotalWeight_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TotalWeight_Textbox.SelectedText = "";
            this.TotalWeight_Textbox.SelectionLength = 0;
            this.TotalWeight_Textbox.SelectionStart = 0;
            this.TotalWeight_Textbox.ShortcutsEnabled = true;
            this.TotalWeight_Textbox.Size = new System.Drawing.Size(143, 23);
            this.TotalWeight_Textbox.TabIndex = 2;
            this.TotalWeight_Textbox.Text = "0";
            this.TotalWeight_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalWeight_Textbox.UseSelectable = true;
            this.TotalWeight_Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TotalWeight_Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel2
            // 
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(727, 120);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(250, 493);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // LedCheck_Button
            // 
            this.LedCheck_Button.Location = new System.Drawing.Point(335, 11);
            this.LedCheck_Button.Name = "LedCheck_Button";
            this.LedCheck_Button.Size = new System.Drawing.Size(75, 23);
            this.LedCheck_Button.TabIndex = 8;
            this.LedCheck_Button.Text = "경광등확인";
            this.LedCheck_Button.UseSelectable = true;
            this.LedCheck_Button.Click += new System.EventHandler(this.LedCheck_Button_Click);
            // 
            // TodayWorkRecords_Datagridview
            // 
            this.TodayWorkRecords_Datagridview.AllowUserToResizeRows = false;
            this.TodayWorkRecords_Datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TodayWorkRecords_Datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TodayWorkRecords_Datagridview.BackgroundColor = System.Drawing.Color.Silver;
            this.TodayWorkRecords_Datagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TodayWorkRecords_Datagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TodayWorkRecords_Datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TodayWorkRecords_Datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TodayWorkRecords_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TodayWorkRecords_Datagridview.DefaultCellStyle = dataGridViewCellStyle5;
            this.TodayWorkRecords_Datagridview.EnableHeadersVisualStyles = false;
            this.TodayWorkRecords_Datagridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TodayWorkRecords_Datagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TodayWorkRecords_Datagridview.Location = new System.Drawing.Point(730, 123);
            this.TodayWorkRecords_Datagridview.Name = "TodayWorkRecords_Datagridview";
            this.TodayWorkRecords_Datagridview.ReadOnly = true;
            this.TodayWorkRecords_Datagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TodayWorkRecords_Datagridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TodayWorkRecords_Datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TodayWorkRecords_Datagridview.RowTemplate.Height = 23;
            this.TodayWorkRecords_Datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TodayWorkRecords_Datagridview.Size = new System.Drawing.Size(244, 487);
            this.TodayWorkRecords_Datagridview.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.TodayWorkRecords_Datagridview);
            this.Controls.Add(this.LedCheck_Button);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.WorkEnd_Button);
            this.Controls.Add(this.WorkStart_Button);
            this.Controls.Add(this.UserManage_Button);
            this.Controls.Add(this.ProductManage_Button);
            this.Controls.Add(this.ExcelExport_Button);
            this.Controls.Add(this.SerialSetting_Button);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TodayWorkRecords_Datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton SerialSetting_Button;
        private MetroFramework.Controls.MetroButton ExcelExport_Button;
        private MetroFramework.Controls.MetroButton ProductManage_Button;
        private MetroFramework.Controls.MetroButton UserManage_Button;
        private MetroFramework.Controls.MetroButton WorkStart_Button;
        private MetroFramework.Controls.MetroButton WorkEnd_Button;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel ProductName_Label;
        private MetroFramework.Controls.MetroLabel WorkCount_Label;
        private MetroFramework.Controls.MetroLabel WorkDate_Label;
        private MetroFramework.Controls.MetroLabel Weight_Label;
        private MetroFramework.Controls.MetroLabel TotalWeight_Label;
        private MetroFramework.Controls.MetroTextBox Weight_Textbox;
        private MetroFramework.Controls.MetroTextBox TotalWeight_Textbox;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel Hi_Label;
        private MetroFramework.Controls.MetroLabel Lo_Label;
        private MetroFramework.Controls.MetroTextBox Lo_Textbox;
        private MetroFramework.Controls.MetroTextBox Hi_Textbox;
        private MetroFramework.Controls.MetroTextBox WorkCount_Textbox;
        private MetroFramework.Controls.MetroTextBox WorkDate_Textbox;
        private MetroFramework.Controls.MetroComboBox Product_Name_Combobox;
        private MetroFramework.Controls.MetroTextBox ScaleValue_Textbox;
        private MetroFramework.Controls.MetroLabel ScaleValue_Label;
        private MetroFramework.Controls.MetroButton LedCheck_Button;
        private MetroFramework.Controls.MetroGrid TodayWorkRecords_Datagridview;
    }
}