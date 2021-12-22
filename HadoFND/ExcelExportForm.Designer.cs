namespace HadoFND
{
    partial class ExcelExportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductList_Label = new MetroFramework.Controls.MetroLabel();
            this.WorkRecordList_Datagridview = new MetroFramework.Controls.MetroGrid();
            this.ExcelExportClose_Button = new MetroFramework.Controls.MetroButton();
            this.ExcelExport_Button = new MetroFramework.Controls.MetroButton();
            this.ProductList_Combobox = new MetroFramework.Controls.MetroComboBox();
            this.DateStart_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.DateStart_Label = new MetroFramework.Controls.MetroLabel();
            this.DateEnd_Label = new MetroFramework.Controls.MetroLabel();
            this.DateEnd_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.FilePath_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.FilePath_Label = new MetroFramework.Controls.MetroLabel();
            this.FilePath_Button = new MetroFramework.Controls.MetroButton();
            this.Search_Button = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.WorkRecordList_Datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductList_Label
            // 
            this.ProductList_Label.AutoSize = true;
            this.ProductList_Label.Location = new System.Drawing.Point(23, 70);
            this.ProductList_Label.Name = "ProductList_Label";
            this.ProductList_Label.Size = new System.Drawing.Size(69, 19);
            this.ProductList_Label.TabIndex = 9;
            this.ProductList_Label.Text = "제품 목록";
            // 
            // WorkRecordList_Datagridview
            // 
            this.WorkRecordList_Datagridview.AllowUserToResizeRows = false;
            this.WorkRecordList_Datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkRecordList_Datagridview.BackgroundColor = System.Drawing.Color.Silver;
            this.WorkRecordList_Datagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorkRecordList_Datagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.WorkRecordList_Datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkRecordList_Datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.WorkRecordList_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WorkRecordList_Datagridview.DefaultCellStyle = dataGridViewCellStyle11;
            this.WorkRecordList_Datagridview.EnableHeadersVisualStyles = false;
            this.WorkRecordList_Datagridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WorkRecordList_Datagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WorkRecordList_Datagridview.Location = new System.Drawing.Point(23, 127);
            this.WorkRecordList_Datagridview.Name = "WorkRecordList_Datagridview";
            this.WorkRecordList_Datagridview.ReadOnly = true;
            this.WorkRecordList_Datagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkRecordList_Datagridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.WorkRecordList_Datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.WorkRecordList_Datagridview.RowTemplate.Height = 23;
            this.WorkRecordList_Datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WorkRecordList_Datagridview.Size = new System.Drawing.Size(440, 300);
            this.WorkRecordList_Datagridview.TabIndex = 11;
            // 
            // ExcelExportClose_Button
            // 
            this.ExcelExportClose_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ExcelExportClose_Button.Location = new System.Drawing.Point(496, 371);
            this.ExcelExportClose_Button.Name = "ExcelExportClose_Button";
            this.ExcelExportClose_Button.Size = new System.Drawing.Size(256, 56);
            this.ExcelExportClose_Button.TabIndex = 13;
            this.ExcelExportClose_Button.Text = "닫기";
            this.ExcelExportClose_Button.UseSelectable = true;
            // 
            // ExcelExport_Button
            // 
            this.ExcelExport_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ExcelExport_Button.Location = new System.Drawing.Point(496, 310);
            this.ExcelExport_Button.Name = "ExcelExport_Button";
            this.ExcelExport_Button.Size = new System.Drawing.Size(256, 55);
            this.ExcelExport_Button.TabIndex = 12;
            this.ExcelExport_Button.Text = "다운로드";
            this.ExcelExport_Button.UseSelectable = true;
            // 
            // ProductList_Combobox
            // 
            this.ProductList_Combobox.FormattingEnabled = true;
            this.ProductList_Combobox.ItemHeight = 23;
            this.ProductList_Combobox.Location = new System.Drawing.Point(23, 92);
            this.ProductList_Combobox.Name = "ProductList_Combobox";
            this.ProductList_Combobox.Size = new System.Drawing.Size(154, 29);
            this.ProductList_Combobox.TabIndex = 17;
            this.ProductList_Combobox.UseSelectable = true;
            // 
            // DateStart_ComboBox
            // 
            this.DateStart_ComboBox.FormattingEnabled = true;
            this.DateStart_ComboBox.ItemHeight = 23;
            this.DateStart_ComboBox.Location = new System.Drawing.Point(183, 92);
            this.DateStart_ComboBox.Name = "DateStart_ComboBox";
            this.DateStart_ComboBox.Size = new System.Drawing.Size(91, 29);
            this.DateStart_ComboBox.TabIndex = 18;
            this.DateStart_ComboBox.UseSelectable = true;
            // 
            // DateStart_Label
            // 
            this.DateStart_Label.AutoSize = true;
            this.DateStart_Label.Location = new System.Drawing.Point(183, 70);
            this.DateStart_Label.Name = "DateStart_Label";
            this.DateStart_Label.Size = new System.Drawing.Size(65, 19);
            this.DateStart_Label.TabIndex = 20;
            this.DateStart_Label.Text = "시작날짜";
            // 
            // DateEnd_Label
            // 
            this.DateEnd_Label.AutoSize = true;
            this.DateEnd_Label.Location = new System.Drawing.Point(280, 70);
            this.DateEnd_Label.Name = "DateEnd_Label";
            this.DateEnd_Label.Size = new System.Drawing.Size(65, 19);
            this.DateEnd_Label.TabIndex = 21;
            this.DateEnd_Label.Text = "종료날짜";
            // 
            // DateEnd_ComboBox
            // 
            this.DateEnd_ComboBox.FormattingEnabled = true;
            this.DateEnd_ComboBox.ItemHeight = 23;
            this.DateEnd_ComboBox.Location = new System.Drawing.Point(280, 92);
            this.DateEnd_ComboBox.Name = "DateEnd_ComboBox";
            this.DateEnd_ComboBox.Size = new System.Drawing.Size(91, 29);
            this.DateEnd_ComboBox.TabIndex = 22;
            this.DateEnd_ComboBox.UseSelectable = true;
            // 
            // FilePath_TextBox
            // 
            // 
            // 
            // 
            this.FilePath_TextBox.CustomButton.Image = null;
            this.FilePath_TextBox.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.FilePath_TextBox.CustomButton.Name = "";
            this.FilePath_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FilePath_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FilePath_TextBox.CustomButton.TabIndex = 1;
            this.FilePath_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FilePath_TextBox.CustomButton.UseSelectable = true;
            this.FilePath_TextBox.CustomButton.Visible = false;
            this.FilePath_TextBox.Lines = new string[0];
            this.FilePath_TextBox.Location = new System.Drawing.Point(496, 98);
            this.FilePath_TextBox.MaxLength = 45;
            this.FilePath_TextBox.Name = "FilePath_TextBox";
            this.FilePath_TextBox.PasswordChar = '\0';
            this.FilePath_TextBox.ReadOnly = true;
            this.FilePath_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FilePath_TextBox.SelectedText = "";
            this.FilePath_TextBox.SelectionLength = 0;
            this.FilePath_TextBox.SelectionStart = 0;
            this.FilePath_TextBox.ShortcutsEnabled = true;
            this.FilePath_TextBox.Size = new System.Drawing.Size(175, 23);
            this.FilePath_TextBox.TabIndex = 24;
            this.FilePath_TextBox.UseSelectable = true;
            this.FilePath_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FilePath_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FilePath_Label
            // 
            this.FilePath_Label.AutoSize = true;
            this.FilePath_Label.Location = new System.Drawing.Point(496, 70);
            this.FilePath_Label.Name = "FilePath_Label";
            this.FilePath_Label.Size = new System.Drawing.Size(101, 19);
            this.FilePath_Label.TabIndex = 23;
            this.FilePath_Label.Text = "파일 저장 위치";
            // 
            // FilePath_Button
            // 
            this.FilePath_Button.Location = new System.Drawing.Point(677, 98);
            this.FilePath_Button.Name = "FilePath_Button";
            this.FilePath_Button.Size = new System.Drawing.Size(75, 23);
            this.FilePath_Button.TabIndex = 25;
            this.FilePath_Button.Text = "경로선택";
            this.FilePath_Button.UseSelectable = true;
            this.FilePath_Button.Click += new System.EventHandler(this.FilePath_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(377, 92);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(86, 29);
            this.Search_Button.TabIndex = 26;
            this.Search_Button.Text = "검색";
            this.Search_Button.UseSelectable = true;
            // 
            // ExcelExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.FilePath_Button);
            this.Controls.Add(this.FilePath_TextBox);
            this.Controls.Add(this.FilePath_Label);
            this.Controls.Add(this.DateEnd_ComboBox);
            this.Controls.Add(this.DateEnd_Label);
            this.Controls.Add(this.DateStart_Label);
            this.Controls.Add(this.DateStart_ComboBox);
            this.Controls.Add(this.ProductList_Combobox);
            this.Controls.Add(this.ExcelExportClose_Button);
            this.Controls.Add(this.ExcelExport_Button);
            this.Controls.Add(this.WorkRecordList_Datagridview);
            this.Controls.Add(this.ProductList_Label);
            this.Name = "ExcelExportForm";
            this.Text = "엑셀 추출";
            this.Load += new System.EventHandler(this.ExcelExportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorkRecordList_Datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel ProductList_Label;
        private MetroFramework.Controls.MetroGrid WorkRecordList_Datagridview;
        private MetroFramework.Controls.MetroButton ExcelExportClose_Button;
        private MetroFramework.Controls.MetroButton ExcelExport_Button;
        private MetroFramework.Controls.MetroComboBox ProductList_Combobox;
        private MetroFramework.Controls.MetroComboBox DateStart_ComboBox;
        private MetroFramework.Controls.MetroLabel DateStart_Label;
        private MetroFramework.Controls.MetroLabel DateEnd_Label;
        private MetroFramework.Controls.MetroComboBox DateEnd_ComboBox;
        private MetroFramework.Controls.MetroTextBox FilePath_TextBox;
        private MetroFramework.Controls.MetroLabel FilePath_Label;
        private MetroFramework.Controls.MetroButton FilePath_Button;
        private MetroFramework.Controls.MetroButton Search_Button;
    }
}