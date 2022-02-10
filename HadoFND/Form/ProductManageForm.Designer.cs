namespace HadoFND
{
    partial class ProductManageForm
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
            this.ProductCodeNumber_Label = new MetroFramework.Controls.MetroLabel();
            this.ProductCodeNumber_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProductName_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProductName_Label = new MetroFramework.Controls.MetroLabel();
            this.ProductWeight_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProductWeight_Label = new MetroFramework.Controls.MetroLabel();
            this.ProductAdd_Button = new MetroFramework.Controls.MetroButton();
            this.ProductList_Label = new MetroFramework.Controls.MetroLabel();
            this.ProductDelete_Button = new MetroFramework.Controls.MetroButton();
            this.ProductList_Datagridview = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList_Datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCodeNumber_Label
            // 
            this.ProductCodeNumber_Label.AutoSize = true;
            this.ProductCodeNumber_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ProductCodeNumber_Label.Location = new System.Drawing.Point(425, 137);
            this.ProductCodeNumber_Label.Name = "ProductCodeNumber_Label";
            this.ProductCodeNumber_Label.Size = new System.Drawing.Size(48, 25);
            this.ProductCodeNumber_Label.TabIndex = 1;
            this.ProductCodeNumber_Label.Text = "품번";
            // 
            // ProductCodeNumber_TextBox
            // 
            this.ProductCodeNumber_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.ProductCodeNumber_TextBox.CustomButton.Image = null;
            this.ProductCodeNumber_TextBox.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.ProductCodeNumber_TextBox.CustomButton.Name = "";
            this.ProductCodeNumber_TextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.ProductCodeNumber_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductCodeNumber_TextBox.CustomButton.TabIndex = 1;
            this.ProductCodeNumber_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductCodeNumber_TextBox.CustomButton.UseSelectable = true;
            this.ProductCodeNumber_TextBox.CustomButton.Visible = false;
            this.ProductCodeNumber_TextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ProductCodeNumber_TextBox.Lines = new string[0];
            this.ProductCodeNumber_TextBox.Location = new System.Drawing.Point(541, 132);
            this.ProductCodeNumber_TextBox.MaxLength = 11;
            this.ProductCodeNumber_TextBox.Name = "ProductCodeNumber_TextBox";
            this.ProductCodeNumber_TextBox.PasswordChar = '\0';
            this.ProductCodeNumber_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductCodeNumber_TextBox.SelectedText = "";
            this.ProductCodeNumber_TextBox.SelectionLength = 0;
            this.ProductCodeNumber_TextBox.SelectionStart = 0;
            this.ProductCodeNumber_TextBox.ShortcutsEnabled = true;
            this.ProductCodeNumber_TextBox.Size = new System.Drawing.Size(166, 33);
            this.ProductCodeNumber_TextBox.TabIndex = 2;
            this.ProductCodeNumber_TextBox.UseSelectable = true;
            this.ProductCodeNumber_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductCodeNumber_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCodeNumber_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductCodeNumber_TextBox_KeyPress);
            // 
            // ProductName_TextBox
            // 
            // 
            // 
            // 
            this.ProductName_TextBox.CustomButton.Image = null;
            this.ProductName_TextBox.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.ProductName_TextBox.CustomButton.Name = "";
            this.ProductName_TextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.ProductName_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductName_TextBox.CustomButton.TabIndex = 1;
            this.ProductName_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductName_TextBox.CustomButton.UseSelectable = true;
            this.ProductName_TextBox.CustomButton.Visible = false;
            this.ProductName_TextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ProductName_TextBox.Lines = new string[0];
            this.ProductName_TextBox.Location = new System.Drawing.Point(541, 188);
            this.ProductName_TextBox.MaxLength = 45;
            this.ProductName_TextBox.Name = "ProductName_TextBox";
            this.ProductName_TextBox.PasswordChar = '\0';
            this.ProductName_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductName_TextBox.SelectedText = "";
            this.ProductName_TextBox.SelectionLength = 0;
            this.ProductName_TextBox.SelectionStart = 0;
            this.ProductName_TextBox.ShortcutsEnabled = true;
            this.ProductName_TextBox.Size = new System.Drawing.Size(166, 33);
            this.ProductName_TextBox.TabIndex = 4;
            this.ProductName_TextBox.UseSelectable = true;
            this.ProductName_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductName_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProductName_Label
            // 
            this.ProductName_Label.AutoSize = true;
            this.ProductName_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ProductName_Label.Location = new System.Drawing.Point(425, 193);
            this.ProductName_Label.Name = "ProductName_Label";
            this.ProductName_Label.Size = new System.Drawing.Size(66, 25);
            this.ProductName_Label.TabIndex = 3;
            this.ProductName_Label.Text = "제품명";
            // 
            // ProductWeight_TextBox
            // 
            this.ProductWeight_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.ProductWeight_TextBox.CustomButton.Image = null;
            this.ProductWeight_TextBox.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.ProductWeight_TextBox.CustomButton.Name = "";
            this.ProductWeight_TextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.ProductWeight_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductWeight_TextBox.CustomButton.TabIndex = 1;
            this.ProductWeight_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductWeight_TextBox.CustomButton.UseSelectable = true;
            this.ProductWeight_TextBox.CustomButton.Visible = false;
            this.ProductWeight_TextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ProductWeight_TextBox.Lines = new string[0];
            this.ProductWeight_TextBox.Location = new System.Drawing.Point(541, 243);
            this.ProductWeight_TextBox.MaxLength = 11;
            this.ProductWeight_TextBox.Name = "ProductWeight_TextBox";
            this.ProductWeight_TextBox.PasswordChar = '\0';
            this.ProductWeight_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductWeight_TextBox.SelectedText = "";
            this.ProductWeight_TextBox.SelectionLength = 0;
            this.ProductWeight_TextBox.SelectionStart = 0;
            this.ProductWeight_TextBox.ShortcutsEnabled = true;
            this.ProductWeight_TextBox.Size = new System.Drawing.Size(166, 33);
            this.ProductWeight_TextBox.TabIndex = 6;
            this.ProductWeight_TextBox.UseSelectable = true;
            this.ProductWeight_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductWeight_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductWeight_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductWeight_TextBox_KeyPress);
            // 
            // ProductWeight_Label
            // 
            this.ProductWeight_Label.AutoSize = true;
            this.ProductWeight_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ProductWeight_Label.Location = new System.Drawing.Point(425, 248);
            this.ProductWeight_Label.Name = "ProductWeight_Label";
            this.ProductWeight_Label.Size = new System.Drawing.Size(104, 25);
            this.ProductWeight_Label.TabIndex = 5;
            this.ProductWeight_Label.Text = "표준중량(g)";
            // 
            // ProductAdd_Button
            // 
            this.ProductAdd_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ProductAdd_Button.Location = new System.Drawing.Point(425, 299);
            this.ProductAdd_Button.Name = "ProductAdd_Button";
            this.ProductAdd_Button.Size = new System.Drawing.Size(282, 55);
            this.ProductAdd_Button.TabIndex = 7;
            this.ProductAdd_Button.Text = "등록";
            this.ProductAdd_Button.UseSelectable = true;
            this.ProductAdd_Button.Click += new System.EventHandler(this.ProductAdd_Button_Click);
            // 
            // ProductList_Label
            // 
            this.ProductList_Label.AutoSize = true;
            this.ProductList_Label.Location = new System.Drawing.Point(23, 92);
            this.ProductList_Label.Name = "ProductList_Label";
            this.ProductList_Label.Size = new System.Drawing.Size(69, 19);
            this.ProductList_Label.TabIndex = 8;
            this.ProductList_Label.Text = "제품 목록";
            // 
            // ProductDelete_Button
            // 
            this.ProductDelete_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ProductDelete_Button.Location = new System.Drawing.Point(425, 369);
            this.ProductDelete_Button.Name = "ProductDelete_Button";
            this.ProductDelete_Button.Size = new System.Drawing.Size(282, 56);
            this.ProductDelete_Button.TabIndex = 9;
            this.ProductDelete_Button.Text = "삭제";
            this.ProductDelete_Button.UseSelectable = true;
            this.ProductDelete_Button.Click += new System.EventHandler(this.ProductDelete_Button_Click);
            // 
            // ProductList_Datagridview
            // 
            this.ProductList_Datagridview.AllowUserToAddRows = false;
            this.ProductList_Datagridview.AllowUserToDeleteRows = false;
            this.ProductList_Datagridview.AllowUserToResizeColumns = false;
            this.ProductList_Datagridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductList_Datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductList_Datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductList_Datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProductList_Datagridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProductList_Datagridview.BackgroundColor = System.Drawing.Color.Silver;
            this.ProductList_Datagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductList_Datagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductList_Datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductList_Datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductList_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductList_Datagridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductList_Datagridview.EnableHeadersVisualStyles = false;
            this.ProductList_Datagridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductList_Datagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductList_Datagridview.Location = new System.Drawing.Point(23, 126);
            this.ProductList_Datagridview.Name = "ProductList_Datagridview";
            this.ProductList_Datagridview.ReadOnly = true;
            this.ProductList_Datagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductList_Datagridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductList_Datagridview.RowHeadersWidth = 40;
            this.ProductList_Datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            this.ProductList_Datagridview.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ProductList_Datagridview.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductList_Datagridview.RowTemplate.Height = 23;
            this.ProductList_Datagridview.RowTemplate.ReadOnly = true;
            this.ProductList_Datagridview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductList_Datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductList_Datagridview.Size = new System.Drawing.Size(380, 300);
            this.ProductList_Datagridview.TabIndex = 10;
            this.ProductList_Datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductList_Datagridview_CellClick);
            this.ProductList_Datagridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductList_Datagridview_CellDoubleClick);
            // 
            // ProductManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.ProductList_Datagridview);
            this.Controls.Add(this.ProductDelete_Button);
            this.Controls.Add(this.ProductList_Label);
            this.Controls.Add(this.ProductAdd_Button);
            this.Controls.Add(this.ProductWeight_TextBox);
            this.Controls.Add(this.ProductWeight_Label);
            this.Controls.Add(this.ProductName_TextBox);
            this.Controls.Add(this.ProductName_Label);
            this.Controls.Add(this.ProductCodeNumber_TextBox);
            this.Controls.Add(this.ProductCodeNumber_Label);
            this.Name = "ProductManageForm";
            this.Text = "제품 관리";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductManageForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductList_Datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel ProductCodeNumber_Label;
        private MetroFramework.Controls.MetroTextBox ProductCodeNumber_TextBox;
        private MetroFramework.Controls.MetroTextBox ProductName_TextBox;
        private MetroFramework.Controls.MetroLabel ProductName_Label;
        private MetroFramework.Controls.MetroTextBox ProductWeight_TextBox;
        private MetroFramework.Controls.MetroLabel ProductWeight_Label;
        private MetroFramework.Controls.MetroButton ProductAdd_Button;
        private MetroFramework.Controls.MetroLabel ProductList_Label;
        private MetroFramework.Controls.MetroButton ProductDelete_Button;
        private MetroFramework.Controls.MetroGrid ProductList_Datagridview;
    }
}