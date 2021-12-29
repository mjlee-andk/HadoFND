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
            this.ProductCodeNumber_Label.Location = new System.Drawing.Point(486, 138);
            this.ProductCodeNumber_Label.Name = "ProductCodeNumber_Label";
            this.ProductCodeNumber_Label.Size = new System.Drawing.Size(37, 19);
            this.ProductCodeNumber_Label.TabIndex = 1;
            this.ProductCodeNumber_Label.Text = "품번";
            // 
            // ProductCodeNumber_TextBox
            // 
            // 
            // 
            // 
            this.ProductCodeNumber_TextBox.CustomButton.Image = null;
            this.ProductCodeNumber_TextBox.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.ProductCodeNumber_TextBox.CustomButton.Name = "";
            this.ProductCodeNumber_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ProductCodeNumber_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductCodeNumber_TextBox.CustomButton.TabIndex = 1;
            this.ProductCodeNumber_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductCodeNumber_TextBox.CustomButton.UseSelectable = true;
            this.ProductCodeNumber_TextBox.CustomButton.Visible = false;
            this.ProductCodeNumber_TextBox.Lines = new string[0];
            this.ProductCodeNumber_TextBox.Location = new System.Drawing.Point(602, 133);
            this.ProductCodeNumber_TextBox.MaxLength = 11;
            this.ProductCodeNumber_TextBox.Name = "ProductCodeNumber_TextBox";
            this.ProductCodeNumber_TextBox.PasswordChar = '\0';
            this.ProductCodeNumber_TextBox.PromptText = "1 이상의 숫자만 입력";
            this.ProductCodeNumber_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductCodeNumber_TextBox.SelectedText = "";
            this.ProductCodeNumber_TextBox.SelectionLength = 0;
            this.ProductCodeNumber_TextBox.SelectionStart = 0;
            this.ProductCodeNumber_TextBox.ShortcutsEnabled = true;
            this.ProductCodeNumber_TextBox.Size = new System.Drawing.Size(140, 23);
            this.ProductCodeNumber_TextBox.TabIndex = 2;
            this.ProductCodeNumber_TextBox.UseSelectable = true;
            this.ProductCodeNumber_TextBox.WaterMark = "1 이상의 숫자만 입력";
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
            this.ProductName_TextBox.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.ProductName_TextBox.CustomButton.Name = "";
            this.ProductName_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ProductName_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductName_TextBox.CustomButton.TabIndex = 1;
            this.ProductName_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductName_TextBox.CustomButton.UseSelectable = true;
            this.ProductName_TextBox.CustomButton.Visible = false;
            this.ProductName_TextBox.Lines = new string[0];
            this.ProductName_TextBox.Location = new System.Drawing.Point(602, 189);
            this.ProductName_TextBox.MaxLength = 45;
            this.ProductName_TextBox.Name = "ProductName_TextBox";
            this.ProductName_TextBox.PasswordChar = '\0';
            this.ProductName_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductName_TextBox.SelectedText = "";
            this.ProductName_TextBox.SelectionLength = 0;
            this.ProductName_TextBox.SelectionStart = 0;
            this.ProductName_TextBox.ShortcutsEnabled = true;
            this.ProductName_TextBox.Size = new System.Drawing.Size(140, 23);
            this.ProductName_TextBox.TabIndex = 4;
            this.ProductName_TextBox.UseSelectable = true;
            this.ProductName_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductName_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProductName_Label
            // 
            this.ProductName_Label.AutoSize = true;
            this.ProductName_Label.Location = new System.Drawing.Point(486, 194);
            this.ProductName_Label.Name = "ProductName_Label";
            this.ProductName_Label.Size = new System.Drawing.Size(51, 19);
            this.ProductName_Label.TabIndex = 3;
            this.ProductName_Label.Text = "제품명";
            // 
            // ProductWeight_TextBox
            // 
            // 
            // 
            // 
            this.ProductWeight_TextBox.CustomButton.Image = null;
            this.ProductWeight_TextBox.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.ProductWeight_TextBox.CustomButton.Name = "";
            this.ProductWeight_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ProductWeight_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductWeight_TextBox.CustomButton.TabIndex = 1;
            this.ProductWeight_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductWeight_TextBox.CustomButton.UseSelectable = true;
            this.ProductWeight_TextBox.CustomButton.Visible = false;
            this.ProductWeight_TextBox.Lines = new string[0];
            this.ProductWeight_TextBox.Location = new System.Drawing.Point(602, 244);
            this.ProductWeight_TextBox.MaxLength = 11;
            this.ProductWeight_TextBox.Name = "ProductWeight_TextBox";
            this.ProductWeight_TextBox.PasswordChar = '\0';
            this.ProductWeight_TextBox.PromptText = "1 이상의 숫자만 입력";
            this.ProductWeight_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductWeight_TextBox.SelectedText = "";
            this.ProductWeight_TextBox.SelectionLength = 0;
            this.ProductWeight_TextBox.SelectionStart = 0;
            this.ProductWeight_TextBox.ShortcutsEnabled = true;
            this.ProductWeight_TextBox.Size = new System.Drawing.Size(140, 23);
            this.ProductWeight_TextBox.TabIndex = 6;
            this.ProductWeight_TextBox.UseSelectable = true;
            this.ProductWeight_TextBox.WaterMark = "1 이상의 숫자만 입력";
            this.ProductWeight_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductWeight_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductWeight_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductWeight_TextBox_KeyPress);
            // 
            // ProductWeight_Label
            // 
            this.ProductWeight_Label.AutoSize = true;
            this.ProductWeight_Label.Location = new System.Drawing.Point(486, 249);
            this.ProductWeight_Label.Name = "ProductWeight_Label";
            this.ProductWeight_Label.Size = new System.Drawing.Size(81, 19);
            this.ProductWeight_Label.TabIndex = 5;
            this.ProductWeight_Label.Text = "표준중량(g)";
            // 
            // ProductAdd_Button
            // 
            this.ProductAdd_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ProductAdd_Button.Location = new System.Drawing.Point(486, 300);
            this.ProductAdd_Button.Name = "ProductAdd_Button";
            this.ProductAdd_Button.Size = new System.Drawing.Size(256, 55);
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
            this.ProductDelete_Button.Location = new System.Drawing.Point(486, 370);
            this.ProductDelete_Button.Name = "ProductDelete_Button";
            this.ProductDelete_Button.Size = new System.Drawing.Size(256, 56);
            this.ProductDelete_Button.TabIndex = 9;
            this.ProductDelete_Button.Text = "삭제";
            this.ProductDelete_Button.UseSelectable = true;
            this.ProductDelete_Button.Click += new System.EventHandler(this.ProductDelete_Button_Click);
            // 
            // ProductList_Datagridview
            // 
            this.ProductList_Datagridview.AllowUserToResizeRows = false;
            this.ProductList_Datagridview.BackgroundColor = System.Drawing.Color.Silver;
            this.ProductList_Datagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductList_Datagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductList_Datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductList_Datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductList_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductList_Datagridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductList_Datagridview.EnableHeadersVisualStyles = false;
            this.ProductList_Datagridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductList_Datagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductList_Datagridview.Location = new System.Drawing.Point(23, 126);
            this.ProductList_Datagridview.Name = "ProductList_Datagridview";
            this.ProductList_Datagridview.ReadOnly = true;
            this.ProductList_Datagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductList_Datagridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductList_Datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductList_Datagridview.RowTemplate.Height = 23;
            this.ProductList_Datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductList_Datagridview.Size = new System.Drawing.Size(440, 300);
            this.ProductList_Datagridview.TabIndex = 10;
            this.ProductList_Datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductList_Datagridview_CellClick);
            // 
            // ProductManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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