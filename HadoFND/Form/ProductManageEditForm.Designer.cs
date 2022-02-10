namespace HadoFND.Form
{
    partial class ProductManageEditForm
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
            this.ProductEditClose_Button = new MetroFramework.Controls.MetroButton();
            this.ProductEditUpdate_Button = new MetroFramework.Controls.MetroButton();
            this.ProductEditWeight_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProductWeight_Label = new MetroFramework.Controls.MetroLabel();
            this.ProductEditName_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProductName_Label = new MetroFramework.Controls.MetroLabel();
            this.ProductEditCodeNumber_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProductCodeNumber_Label = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // ProductEditClose_Button
            // 
            this.ProductEditClose_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ProductEditClose_Button.Location = new System.Drawing.Point(23, 344);
            this.ProductEditClose_Button.Name = "ProductEditClose_Button";
            this.ProductEditClose_Button.Size = new System.Drawing.Size(354, 56);
            this.ProductEditClose_Button.TabIndex = 17;
            this.ProductEditClose_Button.Text = "닫기";
            this.ProductEditClose_Button.UseSelectable = true;
            this.ProductEditClose_Button.Click += new System.EventHandler(this.ProductEditClose_Button_Click);
            // 
            // ProductEditUpdate_Button
            // 
            this.ProductEditUpdate_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ProductEditUpdate_Button.Location = new System.Drawing.Point(23, 274);
            this.ProductEditUpdate_Button.Name = "ProductEditUpdate_Button";
            this.ProductEditUpdate_Button.Size = new System.Drawing.Size(354, 55);
            this.ProductEditUpdate_Button.TabIndex = 16;
            this.ProductEditUpdate_Button.Text = "수정";
            this.ProductEditUpdate_Button.UseSelectable = true;
            this.ProductEditUpdate_Button.Click += new System.EventHandler(this.ProductEditUpdate_Button_Click);
            // 
            // ProductEditWeight_TextBox
            // 
            this.ProductEditWeight_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.ProductEditWeight_TextBox.CustomButton.Image = null;
            this.ProductEditWeight_TextBox.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.ProductEditWeight_TextBox.CustomButton.Name = "";
            this.ProductEditWeight_TextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.ProductEditWeight_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductEditWeight_TextBox.CustomButton.TabIndex = 1;
            this.ProductEditWeight_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductEditWeight_TextBox.CustomButton.UseSelectable = true;
            this.ProductEditWeight_TextBox.CustomButton.Visible = false;
            this.ProductEditWeight_TextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ProductEditWeight_TextBox.Lines = new string[0];
            this.ProductEditWeight_TextBox.Location = new System.Drawing.Point(139, 218);
            this.ProductEditWeight_TextBox.MaxLength = 11;
            this.ProductEditWeight_TextBox.Name = "ProductEditWeight_TextBox";
            this.ProductEditWeight_TextBox.PasswordChar = '\0';
            this.ProductEditWeight_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductEditWeight_TextBox.SelectedText = "";
            this.ProductEditWeight_TextBox.SelectionLength = 0;
            this.ProductEditWeight_TextBox.SelectionStart = 0;
            this.ProductEditWeight_TextBox.ShortcutsEnabled = true;
            this.ProductEditWeight_TextBox.Size = new System.Drawing.Size(228, 33);
            this.ProductEditWeight_TextBox.TabIndex = 15;
            this.ProductEditWeight_TextBox.UseSelectable = true;
            this.ProductEditWeight_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductEditWeight_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductEditWeight_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductEditWeight_TextBox_KeyPress);
            // 
            // ProductWeight_Label
            // 
            this.ProductWeight_Label.AutoSize = true;
            this.ProductWeight_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ProductWeight_Label.Location = new System.Drawing.Point(23, 223);
            this.ProductWeight_Label.Name = "ProductWeight_Label";
            this.ProductWeight_Label.Size = new System.Drawing.Size(104, 25);
            this.ProductWeight_Label.TabIndex = 14;
            this.ProductWeight_Label.Text = "표준중량(g)";
            // 
            // ProductEditName_TextBox
            // 
            // 
            // 
            // 
            this.ProductEditName_TextBox.CustomButton.Image = null;
            this.ProductEditName_TextBox.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.ProductEditName_TextBox.CustomButton.Name = "";
            this.ProductEditName_TextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.ProductEditName_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductEditName_TextBox.CustomButton.TabIndex = 1;
            this.ProductEditName_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductEditName_TextBox.CustomButton.UseSelectable = true;
            this.ProductEditName_TextBox.CustomButton.Visible = false;
            this.ProductEditName_TextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ProductEditName_TextBox.Lines = new string[0];
            this.ProductEditName_TextBox.Location = new System.Drawing.Point(139, 163);
            this.ProductEditName_TextBox.MaxLength = 45;
            this.ProductEditName_TextBox.Name = "ProductEditName_TextBox";
            this.ProductEditName_TextBox.PasswordChar = '\0';
            this.ProductEditName_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductEditName_TextBox.SelectedText = "";
            this.ProductEditName_TextBox.SelectionLength = 0;
            this.ProductEditName_TextBox.SelectionStart = 0;
            this.ProductEditName_TextBox.ShortcutsEnabled = true;
            this.ProductEditName_TextBox.Size = new System.Drawing.Size(228, 33);
            this.ProductEditName_TextBox.TabIndex = 13;
            this.ProductEditName_TextBox.UseSelectable = true;
            this.ProductEditName_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductEditName_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProductName_Label
            // 
            this.ProductName_Label.AutoSize = true;
            this.ProductName_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ProductName_Label.Location = new System.Drawing.Point(23, 168);
            this.ProductName_Label.Name = "ProductName_Label";
            this.ProductName_Label.Size = new System.Drawing.Size(66, 25);
            this.ProductName_Label.TabIndex = 12;
            this.ProductName_Label.Text = "제품명";
            // 
            // ProductEditCodeNumber_TextBox
            // 
            this.ProductEditCodeNumber_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.ProductEditCodeNumber_TextBox.CustomButton.Image = null;
            this.ProductEditCodeNumber_TextBox.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.ProductEditCodeNumber_TextBox.CustomButton.Name = "";
            this.ProductEditCodeNumber_TextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.ProductEditCodeNumber_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductEditCodeNumber_TextBox.CustomButton.TabIndex = 1;
            this.ProductEditCodeNumber_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductEditCodeNumber_TextBox.CustomButton.UseSelectable = true;
            this.ProductEditCodeNumber_TextBox.CustomButton.Visible = false;
            this.ProductEditCodeNumber_TextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ProductEditCodeNumber_TextBox.Lines = new string[0];
            this.ProductEditCodeNumber_TextBox.Location = new System.Drawing.Point(139, 107);
            this.ProductEditCodeNumber_TextBox.MaxLength = 11;
            this.ProductEditCodeNumber_TextBox.Name = "ProductEditCodeNumber_TextBox";
            this.ProductEditCodeNumber_TextBox.PasswordChar = '\0';
            this.ProductEditCodeNumber_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductEditCodeNumber_TextBox.SelectedText = "";
            this.ProductEditCodeNumber_TextBox.SelectionLength = 0;
            this.ProductEditCodeNumber_TextBox.SelectionStart = 0;
            this.ProductEditCodeNumber_TextBox.ShortcutsEnabled = true;
            this.ProductEditCodeNumber_TextBox.Size = new System.Drawing.Size(228, 33);
            this.ProductEditCodeNumber_TextBox.TabIndex = 11;
            this.ProductEditCodeNumber_TextBox.UseSelectable = true;
            this.ProductEditCodeNumber_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductEditCodeNumber_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductEditCodeNumber_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductEditCodeNumber_TextBox_KeyPress);
            // 
            // ProductCodeNumber_Label
            // 
            this.ProductCodeNumber_Label.AutoSize = true;
            this.ProductCodeNumber_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ProductCodeNumber_Label.Location = new System.Drawing.Point(23, 112);
            this.ProductCodeNumber_Label.Name = "ProductCodeNumber_Label";
            this.ProductCodeNumber_Label.Size = new System.Drawing.Size(48, 25);
            this.ProductCodeNumber_Label.TabIndex = 10;
            this.ProductCodeNumber_Label.Text = "품번";
            // 
            // ProductManageEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.ProductEditClose_Button);
            this.Controls.Add(this.ProductEditUpdate_Button);
            this.Controls.Add(this.ProductEditWeight_TextBox);
            this.Controls.Add(this.ProductWeight_Label);
            this.Controls.Add(this.ProductEditName_TextBox);
            this.Controls.Add(this.ProductName_Label);
            this.Controls.Add(this.ProductEditCodeNumber_TextBox);
            this.Controls.Add(this.ProductCodeNumber_Label);
            this.Name = "ProductManageEditForm";
            this.Text = "제품 수정";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductManageEditForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductManageEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton ProductEditClose_Button;
        private MetroFramework.Controls.MetroButton ProductEditUpdate_Button;
        private MetroFramework.Controls.MetroTextBox ProductEditWeight_TextBox;
        private MetroFramework.Controls.MetroLabel ProductWeight_Label;
        private MetroFramework.Controls.MetroTextBox ProductEditName_TextBox;
        private MetroFramework.Controls.MetroLabel ProductName_Label;
        private MetroFramework.Controls.MetroTextBox ProductEditCodeNumber_TextBox;
        private MetroFramework.Controls.MetroLabel ProductCodeNumber_Label;
    }
}