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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SerialSetting_Button = new MetroFramework.Controls.MetroButton();
            this.ExcelExport_Button = new MetroFramework.Controls.MetroButton();
            this.ProductManage_Button = new MetroFramework.Controls.MetroButton();
            this.UserManage_Button = new MetroFramework.Controls.MetroButton();
            this.WorkStartEnd_Button = new MetroFramework.Controls.MetroButton();
            this.LedOn_Button = new MetroFramework.Controls.MetroButton();
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.ProductUnitWeight_Textbox = new MetroFramework.Controls.MetroTextBox();
            this.ProductUnitWeight_Label = new MetroFramework.Controls.MetroLabel();
            this.TotalWeightText_Label = new System.Windows.Forms.Label();
            this.WeightText_Label = new System.Windows.Forms.Label();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.LedOff_Button = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WebsiteUrl_Label = new MetroFramework.Controls.MetroLabel();
            this.SalePlace_Label = new MetroFramework.Controls.MetroLabel();
            this.Address_Label = new MetroFramework.Controls.MetroLabel();
            this.MadeBy_Label = new MetroFramework.Controls.MetroLabel();
            this.MadeByText_Label = new MetroFramework.Controls.MetroLabel();
            this.WebsiteUrlText_Label = new MetroFramework.Controls.MetroLabel();
            this.SalePlaceStoreName_Label = new MetroFramework.Controls.MetroLabel();
            this.SalePlaceStorePhone_Label = new MetroFramework.Controls.MetroLabel();
            this.SalePlaceStoreLeaderName_Label = new MetroFramework.Controls.MetroLabel();
            this.AddressText_Label = new MetroFramework.Controls.MetroLabel();
            this.DB_Backup_Button = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.TodayWorkRecords_Datagridview)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SerialSetting_Button
            // 
            this.SerialSetting_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.SerialSetting_Button.Location = new System.Drawing.Point(11, 22);
            this.SerialSetting_Button.Name = "SerialSetting_Button";
            this.SerialSetting_Button.Size = new System.Drawing.Size(96, 52);
            this.SerialSetting_Button.TabIndex = 0;
            this.SerialSetting_Button.Text = "통신설정";
            this.SerialSetting_Button.UseSelectable = true;
            this.SerialSetting_Button.Click += new System.EventHandler(this.SerialSetting_Button_Click);
            // 
            // ExcelExport_Button
            // 
            this.ExcelExport_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ExcelExport_Button.Location = new System.Drawing.Point(317, 22);
            this.ExcelExport_Button.Name = "ExcelExport_Button";
            this.ExcelExport_Button.Size = new System.Drawing.Size(96, 52);
            this.ExcelExport_Button.TabIndex = 1;
            this.ExcelExport_Button.Text = "작업기록";
            this.ExcelExport_Button.UseSelectable = true;
            this.ExcelExport_Button.Click += new System.EventHandler(this.ExcelExport_Button_Click);
            // 
            // ProductManage_Button
            // 
            this.ProductManage_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ProductManage_Button.Location = new System.Drawing.Point(113, 22);
            this.ProductManage_Button.Name = "ProductManage_Button";
            this.ProductManage_Button.Size = new System.Drawing.Size(96, 52);
            this.ProductManage_Button.TabIndex = 2;
            this.ProductManage_Button.Text = "제품관리";
            this.ProductManage_Button.UseSelectable = true;
            this.ProductManage_Button.Click += new System.EventHandler(this.ProductManage_Button_Click);
            // 
            // UserManage_Button
            // 
            this.UserManage_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.UserManage_Button.Location = new System.Drawing.Point(215, 22);
            this.UserManage_Button.Name = "UserManage_Button";
            this.UserManage_Button.Size = new System.Drawing.Size(96, 52);
            this.UserManage_Button.TabIndex = 3;
            this.UserManage_Button.Text = "유저관리";
            this.UserManage_Button.UseSelectable = true;
            this.UserManage_Button.Click += new System.EventHandler(this.UserManage_Button_Click);
            // 
            // WorkStartEnd_Button
            // 
            this.WorkStartEnd_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.WorkStartEnd_Button.Location = new System.Drawing.Point(781, 40);
            this.WorkStartEnd_Button.Margin = new System.Windows.Forms.Padding(0);
            this.WorkStartEnd_Button.Name = "WorkStartEnd_Button";
            this.WorkStartEnd_Button.Size = new System.Drawing.Size(240, 72);
            this.WorkStartEnd_Button.TabIndex = 4;
            this.WorkStartEnd_Button.Text = "작업시작";
            this.WorkStartEnd_Button.UseSelectable = true;
            this.WorkStartEnd_Button.Click += new System.EventHandler(this.WorkStartEnd_Button_Click);
            // 
            // LedOn_Button
            // 
            this.LedOn_Button.Location = new System.Drawing.Point(521, 22);
            this.LedOn_Button.Name = "LedOn_Button";
            this.LedOn_Button.Size = new System.Drawing.Size(86, 23);
            this.LedOn_Button.TabIndex = 8;
            this.LedOn_Button.Text = "경광등켜기";
            this.LedOn_Button.UseSelectable = true;
            this.LedOn_Button.Click += new System.EventHandler(this.LedOn_Button_Click);
            // 
            // TodayWorkRecords_Datagridview
            // 
            this.TodayWorkRecords_Datagridview.AllowUserToAddRows = false;
            this.TodayWorkRecords_Datagridview.AllowUserToDeleteRows = false;
            this.TodayWorkRecords_Datagridview.AllowUserToResizeColumns = false;
            this.TodayWorkRecords_Datagridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TodayWorkRecords_Datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TodayWorkRecords_Datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TodayWorkRecords_Datagridview.BackgroundColor = System.Drawing.Color.Silver;
            this.TodayWorkRecords_Datagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TodayWorkRecords_Datagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TodayWorkRecords_Datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TodayWorkRecords_Datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TodayWorkRecords_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TodayWorkRecords_Datagridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.TodayWorkRecords_Datagridview.EnableHeadersVisualStyles = false;
            this.TodayWorkRecords_Datagridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TodayWorkRecords_Datagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TodayWorkRecords_Datagridview.Location = new System.Drawing.Point(678, 170);
            this.TodayWorkRecords_Datagridview.Name = "TodayWorkRecords_Datagridview";
            this.TodayWorkRecords_Datagridview.ReadOnly = true;
            this.TodayWorkRecords_Datagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TodayWorkRecords_Datagridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TodayWorkRecords_Datagridview.RowHeadersWidth = 10;
            this.TodayWorkRecords_Datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            this.TodayWorkRecords_Datagridview.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TodayWorkRecords_Datagridview.RowTemplate.Height = 23;
            this.TodayWorkRecords_Datagridview.RowTemplate.ReadOnly = true;
            this.TodayWorkRecords_Datagridview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TodayWorkRecords_Datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TodayWorkRecords_Datagridview.Size = new System.Drawing.Size(433, 519);
            this.TodayWorkRecords_Datagridview.TabIndex = 12;
            // 
            // TotalWeight_Label
            // 
            this.TotalWeight_Label.AutoSize = true;
            this.TotalWeight_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TotalWeight_Label.Location = new System.Drawing.Point(9, 44);
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
            this.Weight_Label.Location = new System.Drawing.Point(9, 138);
            this.Weight_Label.Name = "Weight_Label";
            this.Weight_Label.Size = new System.Drawing.Size(89, 25);
            this.Weight_Label.TabIndex = 5;
            this.Weight_Label.Text = "단위 중량";
            this.Weight_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkDate_Label
            // 
            this.WorkDate_Label.AutoSize = true;
            this.WorkDate_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.WorkDate_Label.Location = new System.Drawing.Point(12, 291);
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
            this.WorkCount_Label.Location = new System.Drawing.Point(12, 349);
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
            this.ProductName_Label.Location = new System.Drawing.Point(12, 229);
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
            this.Lo_Label.Location = new System.Drawing.Point(304, 351);
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
            this.Hi_Label.Location = new System.Drawing.Point(304, 292);
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
            this.WorkDate_Textbox.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.WorkDate_Textbox.CustomButton.Name = "";
            this.WorkDate_Textbox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.WorkDate_Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.WorkDate_Textbox.CustomButton.TabIndex = 1;
            this.WorkDate_Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WorkDate_Textbox.CustomButton.UseSelectable = true;
            this.WorkDate_Textbox.CustomButton.Visible = false;
            this.WorkDate_Textbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.WorkDate_Textbox.Lines = new string[0];
            this.WorkDate_Textbox.Location = new System.Drawing.Point(141, 288);
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
            this.WorkCount_Textbox.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.WorkCount_Textbox.CustomButton.Name = "";
            this.WorkCount_Textbox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.WorkCount_Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.WorkCount_Textbox.CustomButton.TabIndex = 1;
            this.WorkCount_Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WorkCount_Textbox.CustomButton.UseSelectable = true;
            this.WorkCount_Textbox.CustomButton.Visible = false;
            this.WorkCount_Textbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.WorkCount_Textbox.Lines = new string[] {
        "0"};
            this.WorkCount_Textbox.Location = new System.Drawing.Point(141, 347);
            this.WorkCount_Textbox.MaxLength = 32767;
            this.WorkCount_Textbox.Name = "WorkCount_Textbox";
            this.WorkCount_Textbox.PasswordChar = '\0';
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
            this.WorkCount_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WorkCount_Textbox_KeyPress);
            // 
            // Hi_Textbox
            // 
            // 
            // 
            // 
            this.Hi_Textbox.CustomButton.Image = null;
            this.Hi_Textbox.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.Hi_Textbox.CustomButton.Name = "";
            this.Hi_Textbox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.Hi_Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Hi_Textbox.CustomButton.TabIndex = 1;
            this.Hi_Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Hi_Textbox.CustomButton.UseSelectable = true;
            this.Hi_Textbox.CustomButton.Visible = false;
            this.Hi_Textbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Hi_Textbox.Lines = new string[] {
        "0"};
            this.Hi_Textbox.Location = new System.Drawing.Point(416, 288);
            this.Hi_Textbox.MaxLength = 10;
            this.Hi_Textbox.Name = "Hi_Textbox";
            this.Hi_Textbox.PasswordChar = '\0';
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
            this.Hi_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hi_Textbox_KeyPress);
            // 
            // Lo_Textbox
            // 
            // 
            // 
            // 
            this.Lo_Textbox.CustomButton.Image = null;
            this.Lo_Textbox.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.Lo_Textbox.CustomButton.Name = "";
            this.Lo_Textbox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.Lo_Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Lo_Textbox.CustomButton.TabIndex = 1;
            this.Lo_Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Lo_Textbox.CustomButton.UseSelectable = true;
            this.Lo_Textbox.CustomButton.Visible = false;
            this.Lo_Textbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Lo_Textbox.Lines = new string[] {
        "0"};
            this.Lo_Textbox.Location = new System.Drawing.Point(416, 347);
            this.Lo_Textbox.MaxLength = 10;
            this.Lo_Textbox.Name = "Lo_Textbox";
            this.Lo_Textbox.PasswordChar = '\0';
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
            this.Lo_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Lo_Textbox_KeyPress);
            // 
            // Product_Name_Combobox
            // 
            this.Product_Name_Combobox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.Product_Name_Combobox.FormattingEnabled = true;
            this.Product_Name_Combobox.ItemHeight = 29;
            this.Product_Name_Combobox.Location = new System.Drawing.Point(141, 225);
            this.Product_Name_Combobox.Name = "Product_Name_Combobox";
            this.Product_Name_Combobox.Size = new System.Drawing.Size(143, 35);
            this.Product_Name_Combobox.TabIndex = 16;
            this.Product_Name_Combobox.UseSelectable = true;
            this.Product_Name_Combobox.SelectedIndexChanged += new System.EventHandler(this.Product_Name_Combobox_SelectedIndexChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.ProductUnitWeight_Textbox);
            this.metroPanel1.Controls.Add(this.ProductUnitWeight_Label);
            this.metroPanel1.Controls.Add(this.TotalWeightText_Label);
            this.metroPanel1.Controls.Add(this.WeightText_Label);
            this.metroPanel1.Controls.Add(this.htmlLabel3);
            this.metroPanel1.Controls.Add(this.Product_Name_Combobox);
            this.metroPanel1.Controls.Add(this.htmlLabel1);
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
            this.metroPanel1.Location = new System.Drawing.Point(11, 96);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(596, 455);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ProductUnitWeight_Textbox
            // 
            // 
            // 
            // 
            this.ProductUnitWeight_Textbox.CustomButton.Image = null;
            this.ProductUnitWeight_Textbox.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.ProductUnitWeight_Textbox.CustomButton.Name = "";
            this.ProductUnitWeight_Textbox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.ProductUnitWeight_Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductUnitWeight_Textbox.CustomButton.TabIndex = 1;
            this.ProductUnitWeight_Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductUnitWeight_Textbox.CustomButton.UseSelectable = true;
            this.ProductUnitWeight_Textbox.CustomButton.Visible = false;
            this.ProductUnitWeight_Textbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ProductUnitWeight_Textbox.Lines = new string[] {
        "0"};
            this.ProductUnitWeight_Textbox.Location = new System.Drawing.Point(414, 225);
            this.ProductUnitWeight_Textbox.MaxLength = 32767;
            this.ProductUnitWeight_Textbox.Name = "ProductUnitWeight_Textbox";
            this.ProductUnitWeight_Textbox.PasswordChar = '\0';
            this.ProductUnitWeight_Textbox.ReadOnly = true;
            this.ProductUnitWeight_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductUnitWeight_Textbox.SelectedText = "";
            this.ProductUnitWeight_Textbox.SelectionLength = 0;
            this.ProductUnitWeight_Textbox.SelectionStart = 0;
            this.ProductUnitWeight_Textbox.ShortcutsEnabled = true;
            this.ProductUnitWeight_Textbox.Size = new System.Drawing.Size(143, 33);
            this.ProductUnitWeight_Textbox.TabIndex = 22;
            this.ProductUnitWeight_Textbox.Text = "0";
            this.ProductUnitWeight_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductUnitWeight_Textbox.UseSelectable = true;
            this.ProductUnitWeight_Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductUnitWeight_Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProductUnitWeight_Label
            // 
            this.ProductUnitWeight_Label.AutoSize = true;
            this.ProductUnitWeight_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ProductUnitWeight_Label.Location = new System.Drawing.Point(304, 228);
            this.ProductUnitWeight_Label.Name = "ProductUnitWeight_Label";
            this.ProductUnitWeight_Label.Size = new System.Drawing.Size(104, 25);
            this.ProductUnitWeight_Label.TabIndex = 21;
            this.ProductUnitWeight_Label.Text = "단위중량(g)";
            this.ProductUnitWeight_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalWeightText_Label
            // 
            this.TotalWeightText_Label.BackColor = System.Drawing.Color.LightGray;
            this.TotalWeightText_Label.Font = new System.Drawing.Font("돋움", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TotalWeightText_Label.Location = new System.Drawing.Point(139, 17);
            this.TotalWeightText_Label.Name = "TotalWeightText_Label";
            this.TotalWeightText_Label.Size = new System.Drawing.Size(328, 76);
            this.TotalWeightText_Label.TabIndex = 20;
            this.TotalWeightText_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WeightText_Label
            // 
            this.WeightText_Label.BackColor = System.Drawing.Color.LightGray;
            this.WeightText_Label.Font = new System.Drawing.Font("돋움", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WeightText_Label.Location = new System.Drawing.Point(139, 108);
            this.WeightText_Label.Name = "WeightText_Label";
            this.WeightText_Label.Size = new System.Drawing.Size(328, 76);
            this.WeightText_Label.TabIndex = 19;
            this.WeightText_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.htmlLabel3.Location = new System.Drawing.Point(485, 108);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(83, 76);
            this.htmlLabel3.TabIndex = 17;
            this.htmlLabel3.Text = "g";
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
            this.htmlLabel1.Location = new System.Drawing.Point(485, 17);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(83, 76);
            this.htmlLabel1.TabIndex = 16;
            this.htmlLabel1.Text = "kg";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(833, 131);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(130, 25);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "일일 계량 현황";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LedOff_Button
            // 
            this.LedOff_Button.Location = new System.Drawing.Point(521, 51);
            this.LedOff_Button.Name = "LedOff_Button";
            this.LedOff_Button.Size = new System.Drawing.Size(86, 23);
            this.LedOff_Button.TabIndex = 22;
            this.LedOff_Button.Text = "경광등끄기";
            this.LedOff_Button.UseSelectable = true;
            this.LedOff_Button.Click += new System.EventHandler(this.LedOff_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HadoFND.Properties.Resources.andfont;
            this.pictureBox1.Location = new System.Drawing.Point(11, 566);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // WebsiteUrl_Label
            // 
            this.WebsiteUrl_Label.AutoSize = true;
            this.WebsiteUrl_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.WebsiteUrl_Label.Location = new System.Drawing.Point(280, 591);
            this.WebsiteUrl_Label.Name = "WebsiteUrl_Label";
            this.WebsiteUrl_Label.Size = new System.Drawing.Size(75, 25);
            this.WebsiteUrl_Label.TabIndex = 24;
            this.WebsiteUrl_Label.Text = "사이트 :";
            // 
            // SalePlace_Label
            // 
            this.SalePlace_Label.AutoSize = true;
            this.SalePlace_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SalePlace_Label.Location = new System.Drawing.Point(280, 616);
            this.SalePlace_Label.Name = "SalePlace_Label";
            this.SalePlace_Label.Size = new System.Drawing.Size(75, 25);
            this.SalePlace_Label.TabIndex = 25;
            this.SalePlace_Label.Text = "판매처 :";
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Address_Label.Location = new System.Drawing.Point(280, 668);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(77, 25);
            this.Address_Label.TabIndex = 26;
            this.Address_Label.Text = "주    소 :";
            // 
            // MadeBy_Label
            // 
            this.MadeBy_Label.AutoSize = true;
            this.MadeBy_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MadeBy_Label.Location = new System.Drawing.Point(280, 566);
            this.MadeBy_Label.Name = "MadeBy_Label";
            this.MadeBy_Label.Size = new System.Drawing.Size(75, 25);
            this.MadeBy_Label.TabIndex = 27;
            this.MadeBy_Label.Text = "제조사 :";
            // 
            // MadeByText_Label
            // 
            this.MadeByText_Label.AutoSize = true;
            this.MadeByText_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MadeByText_Label.Location = new System.Drawing.Point(361, 566);
            this.MadeByText_Label.Name = "MadeByText_Label";
            this.MadeByText_Label.Size = new System.Drawing.Size(128, 25);
            this.MadeByText_Label.TabIndex = 28;
            this.MadeByText_Label.Text = "한국에이.엔.디";
            // 
            // WebsiteUrlText_Label
            // 
            this.WebsiteUrlText_Label.AutoSize = true;
            this.WebsiteUrlText_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.WebsiteUrlText_Label.Location = new System.Drawing.Point(361, 591);
            this.WebsiteUrlText_Label.Name = "WebsiteUrlText_Label";
            this.WebsiteUrlText_Label.Size = new System.Drawing.Size(176, 25);
            this.WebsiteUrlText_Label.TabIndex = 29;
            this.WebsiteUrlText_Label.Text = "http://www.andk.co.kr";
            // 
            // SalePlaceStoreName_Label
            // 
            this.SalePlaceStoreName_Label.AutoSize = true;
            this.SalePlaceStoreName_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SalePlaceStoreName_Label.Location = new System.Drawing.Point(361, 616);
            this.SalePlaceStoreName_Label.Name = "SalePlaceStoreName_Label";
            this.SalePlaceStoreName_Label.Size = new System.Drawing.Size(107, 25);
            this.SalePlaceStoreName_Label.TabIndex = 30;
            this.SalePlaceStoreName_Label.Text = "카스 포천점";
            // 
            // SalePlaceStorePhone_Label
            // 
            this.SalePlaceStorePhone_Label.AutoSize = true;
            this.SalePlaceStorePhone_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SalePlaceStorePhone_Label.Location = new System.Drawing.Point(474, 616);
            this.SalePlaceStorePhone_Label.Name = "SalePlaceStorePhone_Label";
            this.SalePlaceStorePhone_Label.Size = new System.Drawing.Size(105, 25);
            this.SalePlaceStorePhone_Label.TabIndex = 31;
            this.SalePlaceStorePhone_Label.Text = "031-541-6116";
            // 
            // SalePlaceStoreLeaderName_Label
            // 
            this.SalePlaceStoreLeaderName_Label.AutoSize = true;
            this.SalePlaceStoreLeaderName_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SalePlaceStoreLeaderName_Label.Location = new System.Drawing.Point(361, 643);
            this.SalePlaceStoreLeaderName_Label.Name = "SalePlaceStoreLeaderName_Label";
            this.SalePlaceStoreLeaderName_Label.Size = new System.Drawing.Size(143, 25);
            this.SalePlaceStoreLeaderName_Label.TabIndex = 31;
            this.SalePlaceStoreLeaderName_Label.Text = "대표이사 홍재문";
            // 
            // AddressText_Label
            // 
            this.AddressText_Label.AutoSize = true;
            this.AddressText_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.AddressText_Label.Location = new System.Drawing.Point(361, 668);
            this.AddressText_Label.Name = "AddressText_Label";
            this.AddressText_Label.Size = new System.Drawing.Size(300, 25);
            this.AddressText_Label.TabIndex = 32;
            this.AddressText_Label.Text = "경기도 포천시 소흘읍 송우1리 110-28";
            // 
            // DB_Backup_Button
            // 
            this.DB_Backup_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.DB_Backup_Button.Location = new System.Drawing.Point(419, 22);
            this.DB_Backup_Button.Name = "DB_Backup_Button";
            this.DB_Backup_Button.Size = new System.Drawing.Size(96, 52);
            this.DB_Backup_Button.TabIndex = 33;
            this.DB_Backup_Button.Text = "DB백업";
            this.DB_Backup_Button.UseSelectable = true;
            this.DB_Backup_Button.Click += new System.EventHandler(this.DB_Backup_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 732);
            this.Controls.Add(this.DB_Backup_Button);
            this.Controls.Add(this.AddressText_Label);
            this.Controls.Add(this.SalePlaceStoreLeaderName_Label);
            this.Controls.Add(this.SalePlaceStoreName_Label);
            this.Controls.Add(this.SalePlaceStorePhone_Label);
            this.Controls.Add(this.WebsiteUrlText_Label);
            this.Controls.Add(this.MadeByText_Label);
            this.Controls.Add(this.MadeBy_Label);
            this.Controls.Add(this.Address_Label);
            this.Controls.Add(this.SalePlace_Label);
            this.Controls.Add(this.WebsiteUrl_Label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LedOff_Button);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.TodayWorkRecords_Datagridview);
            this.Controls.Add(this.LedOn_Button);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.WorkStartEnd_Button);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton SerialSetting_Button;
        private MetroFramework.Controls.MetroButton ExcelExport_Button;
        private MetroFramework.Controls.MetroButton ProductManage_Button;
        private MetroFramework.Controls.MetroButton UserManage_Button;
        private MetroFramework.Controls.MetroButton WorkStartEnd_Button;
        private MetroFramework.Controls.MetroButton LedOn_Button;
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
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroButton LedOff_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel WebsiteUrl_Label;
        private MetroFramework.Controls.MetroLabel SalePlace_Label;
        private MetroFramework.Controls.MetroLabel Address_Label;
        private MetroFramework.Controls.MetroLabel MadeBy_Label;
        private MetroFramework.Controls.MetroLabel MadeByText_Label;
        private MetroFramework.Controls.MetroLabel SalePlaceStoreLeaderName_Label;
        private MetroFramework.Controls.MetroLabel WebsiteUrlText_Label;
        private MetroFramework.Controls.MetroLabel SalePlaceStoreName_Label;
        private MetroFramework.Controls.MetroLabel SalePlaceStorePhone_Label;
        private MetroFramework.Controls.MetroLabel AddressText_Label;
        private System.Windows.Forms.Label WeightText_Label;
        private System.Windows.Forms.Label TotalWeightText_Label;
        private MetroFramework.Controls.MetroTextBox ProductUnitWeight_Textbox;
        private MetroFramework.Controls.MetroLabel ProductUnitWeight_Label;
        private MetroFramework.Controls.MetroButton DB_Backup_Button;
    }
}