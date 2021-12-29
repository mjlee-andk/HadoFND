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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SerialSetting_Button = new MetroFramework.Controls.MetroButton();
            this.ExcelExport_Button = new MetroFramework.Controls.MetroButton();
            this.ProductManage_Button = new MetroFramework.Controls.MetroButton();
            this.UserManage_Button = new MetroFramework.Controls.MetroButton();
            this.WorkStart_Button = new MetroFramework.Controls.MetroButton();
            this.WorkEnd_Button = new MetroFramework.Controls.MetroButton();
            this.LedCheck_Button = new MetroFramework.Controls.MetroButton();
            this.TodayWorkRecords_Datagridview = new MetroFramework.Controls.MetroGrid();
            this.TotalWeight_Label = new MetroFramework.Controls.MetroLabel();
            this.Weight_Label = new MetroFramework.Controls.MetroLabel();
            this.WorkDate_Label = new MetroFramework.Controls.MetroLabel();
            this.WorkCount_Label = new MetroFramework.Controls.MetroLabel();
            this.ProductName_Label = new MetroFramework.Controls.MetroLabel();
            this.Lo_Label = new MetroFramework.Controls.MetroLabel();
            this.Hi_Label = new MetroFramework.Controls.MetroLabel();
            this.WorkDate_Textbox = new MetroFramework.Controls.MetroTextBox();
            this.WorkCount_Textbox = new MetroFramework.Controls.MetroTextBox();
            this.Hi_Textbox = new MetroFramework.Controls.MetroTextBox();
            this.Lo_Textbox = new MetroFramework.Controls.MetroTextBox();
            this.Product_Name_Combobox = new MetroFramework.Controls.MetroComboBox();
            this.ScaleValue_Label = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.TotalWeight_HtmlLabel = new MetroFramework.Drawing.Html.HtmlLabel();
            this.ScaleValue_HtmlLabel = new MetroFramework.Drawing.Html.HtmlLabel();
            this.Weight_HtmlLabel = new MetroFramework.Drawing.Html.HtmlLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TodayWorkRecords_Datagridview)).BeginInit();
            this.metroPanel1.SuspendLayout();
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
            this.WorkStart_Button.Location = new System.Drawing.Point(638, 40);
            this.WorkStart_Button.Name = "WorkStart_Button";
            this.WorkStart_Button.Size = new System.Drawing.Size(148, 61);
            this.WorkStart_Button.TabIndex = 4;
            this.WorkStart_Button.Text = "작업시작";
            this.WorkStart_Button.UseSelectable = true;
            this.WorkStart_Button.Click += new System.EventHandler(this.WorkStart_Button_Click);
            // 
            // WorkEnd_Button
            // 
            this.WorkEnd_Button.Enabled = false;
            this.WorkEnd_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.WorkEnd_Button.Location = new System.Drawing.Point(820, 40);
            this.WorkEnd_Button.Name = "WorkEnd_Button";
            this.WorkEnd_Button.Size = new System.Drawing.Size(148, 61);
            this.WorkEnd_Button.TabIndex = 5;
            this.WorkEnd_Button.Text = "작업종료";
            this.WorkEnd_Button.UseSelectable = true;
            this.WorkEnd_Button.Click += new System.EventHandler(this.WorkEnd_Button_Click);
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TodayWorkRecords_Datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.TodayWorkRecords_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TodayWorkRecords_Datagridview.DefaultCellStyle = dataGridViewCellStyle14;
            this.TodayWorkRecords_Datagridview.EnableHeadersVisualStyles = false;
            this.TodayWorkRecords_Datagridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TodayWorkRecords_Datagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TodayWorkRecords_Datagridview.Location = new System.Drawing.Point(625, 170);
            this.TodayWorkRecords_Datagridview.Name = "TodayWorkRecords_Datagridview";
            this.TodayWorkRecords_Datagridview.ReadOnly = true;
            this.TodayWorkRecords_Datagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TodayWorkRecords_Datagridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.TodayWorkRecords_Datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TodayWorkRecords_Datagridview.RowTemplate.Height = 23;
            this.TodayWorkRecords_Datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TodayWorkRecords_Datagridview.Size = new System.Drawing.Size(361, 437);
            this.TodayWorkRecords_Datagridview.TabIndex = 12;
            // 
            // TotalWeight_Label
            // 
            this.TotalWeight_Label.AutoSize = true;
            this.TotalWeight_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TotalWeight_Label.Location = new System.Drawing.Point(12, 66);
            this.TotalWeight_Label.Name = "TotalWeight_Label";
            this.TotalWeight_Label.Size = new System.Drawing.Size(112, 25);
            this.TotalWeight_Label.TabIndex = 4;
            this.TotalWeight_Label.Text = "총 작업 중량";
            this.TotalWeight_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Weight_Label
            // 
            this.Weight_Label.AutoSize = true;
            this.Weight_Label.BackColor = System.Drawing.Color.Black;
            this.Weight_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Weight_Label.ForeColor = System.Drawing.Color.Black;
            this.Weight_Label.Location = new System.Drawing.Point(12, 155);
            this.Weight_Label.Name = "Weight_Label";
            this.Weight_Label.Size = new System.Drawing.Size(89, 25);
            this.Weight_Label.TabIndex = 5;
            this.Weight_Label.Text = "추가 중량";
            this.Weight_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkDate_Label
            // 
            this.WorkDate_Label.AutoSize = true;
            this.WorkDate_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.WorkDate_Label.Location = new System.Drawing.Point(12, 440);
            this.WorkDate_Label.Name = "WorkDate_Label";
            this.WorkDate_Label.Size = new System.Drawing.Size(84, 25);
            this.WorkDate_Label.TabIndex = 6;
            this.WorkDate_Label.Text = "작업일자";
            this.WorkDate_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkCount_Label
            // 
            this.WorkCount_Label.AutoSize = true;
            this.WorkCount_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.WorkCount_Label.Location = new System.Drawing.Point(12, 498);
            this.WorkCount_Label.Name = "WorkCount_Label";
            this.WorkCount_Label.Size = new System.Drawing.Size(66, 25);
            this.WorkCount_Label.TabIndex = 7;
            this.WorkCount_Label.Text = "작업수";
            this.WorkCount_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductName_Label
            // 
            this.ProductName_Label.AutoSize = true;
            this.ProductName_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ProductName_Label.Location = new System.Drawing.Point(12, 380);
            this.ProductName_Label.Name = "ProductName_Label";
            this.ProductName_Label.Size = new System.Drawing.Size(66, 25);
            this.ProductName_Label.TabIndex = 8;
            this.ProductName_Label.Text = "제품명";
            this.ProductName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lo_Label
            // 
            this.Lo_Label.AutoSize = true;
            this.Lo_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Lo_Label.Location = new System.Drawing.Point(324, 440);
            this.Lo_Label.Name = "Lo_Label";
            this.Lo_Label.Size = new System.Drawing.Size(68, 25);
            this.Lo_Label.TabIndex = 9;
            this.Lo_Label.Text = "하한(g)";
            this.Lo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hi_Label
            // 
            this.Hi_Label.AutoSize = true;
            this.Hi_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Hi_Label.Location = new System.Drawing.Point(324, 380);
            this.Hi_Label.Name = "Hi_Label";
            this.Hi_Label.Size = new System.Drawing.Size(68, 25);
            this.Hi_Label.TabIndex = 10;
            this.Hi_Label.Text = "상한(g)";
            this.Hi_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.WorkDate_Textbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.WorkDate_Textbox.Lines = new string[0];
            this.WorkDate_Textbox.Location = new System.Drawing.Point(162, 438);
            this.WorkDate_Textbox.MaxLength = 32767;
            this.WorkDate_Textbox.Name = "WorkDate_Textbox";
            this.WorkDate_Textbox.PasswordChar = '\0';
            this.WorkDate_Textbox.ReadOnly = true;
            this.WorkDate_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WorkDate_Textbox.SelectedText = "";
            this.WorkDate_Textbox.SelectionLength = 0;
            this.WorkDate_Textbox.SelectionStart = 0;
            this.WorkDate_Textbox.ShortcutsEnabled = true;
            this.WorkDate_Textbox.Size = new System.Drawing.Size(143, 33);
            this.WorkDate_Textbox.TabIndex = 11;
            this.WorkDate_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WorkDate_Textbox.UseSelectable = true;
            this.WorkDate_Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WorkDate_Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // WorkCount_Textbox
            // 
            this.WorkCount_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.WorkCount_Textbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.WorkCount_Textbox.Lines = new string[] {
        "0"};
            this.WorkCount_Textbox.Location = new System.Drawing.Point(162, 497);
            this.WorkCount_Textbox.MaxLength = 32767;
            this.WorkCount_Textbox.Name = "WorkCount_Textbox";
            this.WorkCount_Textbox.PasswordChar = '\0';
            this.WorkCount_Textbox.ReadOnly = true;
            this.WorkCount_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WorkCount_Textbox.SelectedText = "";
            this.WorkCount_Textbox.SelectionLength = 0;
            this.WorkCount_Textbox.SelectionStart = 0;
            this.WorkCount_Textbox.ShortcutsEnabled = true;
            this.WorkCount_Textbox.Size = new System.Drawing.Size(143, 33);
            this.WorkCount_Textbox.TabIndex = 12;
            this.WorkCount_Textbox.Text = "0";
            this.WorkCount_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WorkCount_Textbox.UseSelectable = true;
            this.WorkCount_Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WorkCount_Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.Hi_Textbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Hi_Textbox.Lines = new string[] {
        "0"};
            this.Hi_Textbox.Location = new System.Drawing.Point(416, 377);
            this.Hi_Textbox.MaxLength = 32767;
            this.Hi_Textbox.Name = "Hi_Textbox";
            this.Hi_Textbox.PasswordChar = '\0';
            this.Hi_Textbox.ReadOnly = true;
            this.Hi_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Hi_Textbox.SelectedText = "";
            this.Hi_Textbox.SelectionLength = 0;
            this.Hi_Textbox.SelectionStart = 0;
            this.Hi_Textbox.ShortcutsEnabled = true;
            this.Hi_Textbox.Size = new System.Drawing.Size(143, 33);
            this.Hi_Textbox.TabIndex = 14;
            this.Hi_Textbox.Text = "0";
            this.Hi_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hi_Textbox.UseSelectable = true;
            this.Hi_Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Hi_Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.Lo_Textbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Lo_Textbox.Lines = new string[] {
        "0"};
            this.Lo_Textbox.Location = new System.Drawing.Point(416, 438);
            this.Lo_Textbox.MaxLength = 32767;
            this.Lo_Textbox.Name = "Lo_Textbox";
            this.Lo_Textbox.PasswordChar = '\0';
            this.Lo_Textbox.ReadOnly = true;
            this.Lo_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Lo_Textbox.SelectedText = "";
            this.Lo_Textbox.SelectionLength = 0;
            this.Lo_Textbox.SelectionStart = 0;
            this.Lo_Textbox.ShortcutsEnabled = true;
            this.Lo_Textbox.Size = new System.Drawing.Size(143, 33);
            this.Lo_Textbox.TabIndex = 15;
            this.Lo_Textbox.Text = "0";
            this.Lo_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Lo_Textbox.UseSelectable = true;
            this.Lo_Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lo_Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Product_Name_Combobox
            // 
            this.Product_Name_Combobox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.Product_Name_Combobox.FormattingEnabled = true;
            this.Product_Name_Combobox.ItemHeight = 29;
            this.Product_Name_Combobox.Location = new System.Drawing.Point(162, 375);
            this.Product_Name_Combobox.Name = "Product_Name_Combobox";
            this.Product_Name_Combobox.Size = new System.Drawing.Size(143, 35);
            this.Product_Name_Combobox.TabIndex = 16;
            this.Product_Name_Combobox.UseSelectable = true;
            this.Product_Name_Combobox.SelectedIndexChanged += new System.EventHandler(this.Product_Name_Combobox_SelectedIndexChanged);
            // 
            // ScaleValue_Label
            // 
            this.ScaleValue_Label.AutoSize = true;
            this.ScaleValue_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ScaleValue_Label.Location = new System.Drawing.Point(12, 246);
            this.ScaleValue_Label.Name = "ScaleValue_Label";
            this.ScaleValue_Label.Size = new System.Drawing.Size(89, 25);
            this.ScaleValue_Label.TabIndex = 17;
            this.ScaleValue_Label.Text = "저울 중량";
            this.ScaleValue_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.htmlLabel3);
            this.metroPanel1.Controls.Add(this.htmlLabel2);
            this.metroPanel1.Controls.Add(this.htmlLabel1);
            this.metroPanel1.Controls.Add(this.TotalWeight_HtmlLabel);
            this.metroPanel1.Controls.Add(this.ScaleValue_HtmlLabel);
            this.metroPanel1.Controls.Add(this.Weight_HtmlLabel);
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
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(11, 40);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(596, 567);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // TotalWeight_HtmlLabel
            // 
            this.TotalWeight_HtmlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalWeight_HtmlLabel.AutoScroll = true;
            this.TotalWeight_HtmlLabel.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.TotalWeight_HtmlLabel.AutoSize = false;
            this.TotalWeight_HtmlLabel.BackColor = System.Drawing.Color.LightGray;
            this.TotalWeight_HtmlLabel.Font = new System.Drawing.Font("돋움", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TotalWeight_HtmlLabel.ForeColor = System.Drawing.Color.Black;
            this.TotalWeight_HtmlLabel.Location = new System.Drawing.Point(162, 39);
            this.TotalWeight_HtmlLabel.Name = "TotalWeight_HtmlLabel";
            this.TotalWeight_HtmlLabel.Size = new System.Drawing.Size(266, 76);
            this.TotalWeight_HtmlLabel.TabIndex = 15;
            // 
            // ScaleValue_HtmlLabel
            // 
            this.ScaleValue_HtmlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleValue_HtmlLabel.AutoScroll = true;
            this.ScaleValue_HtmlLabel.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.ScaleValue_HtmlLabel.AutoSize = false;
            this.ScaleValue_HtmlLabel.BackColor = System.Drawing.Color.LightGray;
            this.ScaleValue_HtmlLabel.Font = new System.Drawing.Font("돋움", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScaleValue_HtmlLabel.ForeColor = System.Drawing.Color.Black;
            this.ScaleValue_HtmlLabel.Location = new System.Drawing.Point(162, 225);
            this.ScaleValue_HtmlLabel.Name = "ScaleValue_HtmlLabel";
            this.ScaleValue_HtmlLabel.Size = new System.Drawing.Size(266, 76);
            this.ScaleValue_HtmlLabel.TabIndex = 14;
            // 
            // Weight_HtmlLabel
            // 
            this.Weight_HtmlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Weight_HtmlLabel.AutoScroll = true;
            this.Weight_HtmlLabel.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.Weight_HtmlLabel.AutoSize = false;
            this.Weight_HtmlLabel.BackColor = System.Drawing.Color.LightGray;
            this.Weight_HtmlLabel.Font = new System.Drawing.Font("돋움", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Weight_HtmlLabel.ForeColor = System.Drawing.Color.Black;
            this.Weight_HtmlLabel.Location = new System.Drawing.Point(162, 131);
            this.Weight_HtmlLabel.Name = "Weight_HtmlLabel";
            this.Weight_HtmlLabel.Size = new System.Drawing.Size(266, 76);
            this.Weight_HtmlLabel.TabIndex = 13;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(746, 130);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(130, 25);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "일일 계량 현황";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(81, 74);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.Color.White;
            this.htmlLabel1.Font = new System.Drawing.Font("돋움", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.htmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.htmlLabel1.Location = new System.Drawing.Point(434, 39);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(83, 76);
            this.htmlLabel1.TabIndex = 16;
            this.htmlLabel1.Text = "kg";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(81, 74);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.Color.White;
            this.htmlLabel2.Font = new System.Drawing.Font("돋움", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.htmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.htmlLabel2.Location = new System.Drawing.Point(434, 225);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(83, 76);
            this.htmlLabel2.TabIndex = 17;
            this.htmlLabel2.Text = "kg";
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(50, 74);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.Color.White;
            this.htmlLabel3.Font = new System.Drawing.Font("돋움", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.htmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.htmlLabel3.Location = new System.Drawing.Point(434, 131);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(83, 76);
            this.htmlLabel3.TabIndex = 17;
            this.htmlLabel3.Text = "g";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.TodayWorkRecords_Datagridview);
            this.Controls.Add(this.LedCheck_Button);
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
            ((System.ComponentModel.ISupportInitialize)(this.TodayWorkRecords_Datagridview)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton SerialSetting_Button;
        private MetroFramework.Controls.MetroButton ExcelExport_Button;
        private MetroFramework.Controls.MetroButton ProductManage_Button;
        private MetroFramework.Controls.MetroButton UserManage_Button;
        private MetroFramework.Controls.MetroButton WorkStart_Button;
        private MetroFramework.Controls.MetroButton WorkEnd_Button;
        private MetroFramework.Controls.MetroButton LedCheck_Button;
        private MetroFramework.Controls.MetroGrid TodayWorkRecords_Datagridview;
        private MetroFramework.Controls.MetroLabel TotalWeight_Label;
        private MetroFramework.Controls.MetroLabel Weight_Label;
        private MetroFramework.Controls.MetroLabel WorkDate_Label;
        private MetroFramework.Controls.MetroLabel WorkCount_Label;
        private MetroFramework.Controls.MetroLabel ProductName_Label;
        private MetroFramework.Controls.MetroLabel Lo_Label;
        private MetroFramework.Controls.MetroLabel Hi_Label;
        private MetroFramework.Controls.MetroTextBox WorkDate_Textbox;
        private MetroFramework.Controls.MetroTextBox WorkCount_Textbox;
        private MetroFramework.Controls.MetroTextBox Hi_Textbox;
        private MetroFramework.Controls.MetroTextBox Lo_Textbox;
        private MetroFramework.Controls.MetroComboBox Product_Name_Combobox;
        private MetroFramework.Controls.MetroLabel ScaleValue_Label;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Drawing.Html.HtmlLabel Weight_HtmlLabel;
        private MetroFramework.Drawing.Html.HtmlLabel ScaleValue_HtmlLabel;
        private MetroFramework.Drawing.Html.HtmlLabel TotalWeight_HtmlLabel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
    }
}