namespace HadoFND
{
    partial class SerialSettingForm
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
            this.Indicator_Label = new MetroFramework.Controls.MetroLabel();
            this.Led_Label = new MetroFramework.Controls.MetroLabel();
            this.Indicator_Port_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.Indicator_Parity_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.Indicator_Databits_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.Indicator_BaudRate_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.Indicator_Stopbits_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.Led_Stopbits_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.Led_BaudRate_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.Led_Databits_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.Led_Parity_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.Led_Port_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.Port_Label = new MetroFramework.Controls.MetroLabel();
            this.BaudRate_Label = new MetroFramework.Controls.MetroLabel();
            this.Databits_Label = new MetroFramework.Controls.MetroLabel();
            this.Parity_Label = new MetroFramework.Controls.MetroLabel();
            this.Stopbits_Label = new MetroFramework.Controls.MetroLabel();
            this.Serial_Save_Button = new MetroFramework.Controls.MetroButton();
            this.Serial_Close_Button = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Indicator_Label
            // 
            this.Indicator_Label.AutoSize = true;
            this.Indicator_Label.Location = new System.Drawing.Point(23, 147);
            this.Indicator_Label.Name = "Indicator_Label";
            this.Indicator_Label.Size = new System.Drawing.Size(79, 19);
            this.Indicator_Label.TabIndex = 1;
            this.Indicator_Label.Text = "인디케이터";
            // 
            // Led_Label
            // 
            this.Led_Label.AutoSize = true;
            this.Led_Label.Location = new System.Drawing.Point(24, 203);
            this.Led_Label.Name = "Led_Label";
            this.Led_Label.Size = new System.Drawing.Size(51, 19);
            this.Led_Label.TabIndex = 2;
            this.Led_Label.Text = "경광등";
            // 
            // Indicator_Port_ComboBox
            // 
            this.Indicator_Port_ComboBox.FormattingEnabled = true;
            this.Indicator_Port_ComboBox.ItemHeight = 23;
            this.Indicator_Port_ComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20"});
            this.Indicator_Port_ComboBox.Location = new System.Drawing.Point(120, 137);
            this.Indicator_Port_ComboBox.Name = "Indicator_Port_ComboBox";
            this.Indicator_Port_ComboBox.Size = new System.Drawing.Size(87, 29);
            this.Indicator_Port_ComboBox.TabIndex = 3;
            this.Indicator_Port_ComboBox.UseSelectable = true;
            // 
            // Indicator_Parity_ComboBox
            // 
            this.Indicator_Parity_ComboBox.FormattingEnabled = true;
            this.Indicator_Parity_ComboBox.ItemHeight = 23;
            this.Indicator_Parity_ComboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.Indicator_Parity_ComboBox.Location = new System.Drawing.Point(399, 137);
            this.Indicator_Parity_ComboBox.Name = "Indicator_Parity_ComboBox";
            this.Indicator_Parity_ComboBox.Size = new System.Drawing.Size(87, 29);
            this.Indicator_Parity_ComboBox.TabIndex = 4;
            this.Indicator_Parity_ComboBox.UseSelectable = true;
            // 
            // Indicator_Databits_ComboBox
            // 
            this.Indicator_Databits_ComboBox.FormattingEnabled = true;
            this.Indicator_Databits_ComboBox.ItemHeight = 23;
            this.Indicator_Databits_ComboBox.Items.AddRange(new object[] {
            "7",
            "8"});
            this.Indicator_Databits_ComboBox.Location = new System.Drawing.Point(306, 137);
            this.Indicator_Databits_ComboBox.Name = "Indicator_Databits_ComboBox";
            this.Indicator_Databits_ComboBox.Size = new System.Drawing.Size(87, 29);
            this.Indicator_Databits_ComboBox.TabIndex = 5;
            this.Indicator_Databits_ComboBox.UseSelectable = true;
            // 
            // Indicator_BaudRate_ComboBox
            // 
            this.Indicator_BaudRate_ComboBox.FormattingEnabled = true;
            this.Indicator_BaudRate_ComboBox.ItemHeight = 23;
            this.Indicator_BaudRate_ComboBox.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.Indicator_BaudRate_ComboBox.Location = new System.Drawing.Point(213, 137);
            this.Indicator_BaudRate_ComboBox.Name = "Indicator_BaudRate_ComboBox";
            this.Indicator_BaudRate_ComboBox.Size = new System.Drawing.Size(87, 29);
            this.Indicator_BaudRate_ComboBox.TabIndex = 6;
            this.Indicator_BaudRate_ComboBox.UseSelectable = true;
            // 
            // Indicator_Stopbits_ComboBox
            // 
            this.Indicator_Stopbits_ComboBox.FormattingEnabled = true;
            this.Indicator_Stopbits_ComboBox.ItemHeight = 23;
            this.Indicator_Stopbits_ComboBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.Indicator_Stopbits_ComboBox.Location = new System.Drawing.Point(492, 137);
            this.Indicator_Stopbits_ComboBox.Name = "Indicator_Stopbits_ComboBox";
            this.Indicator_Stopbits_ComboBox.Size = new System.Drawing.Size(87, 29);
            this.Indicator_Stopbits_ComboBox.TabIndex = 7;
            this.Indicator_Stopbits_ComboBox.UseSelectable = true;
            // 
            // Led_Stopbits_ComboBox
            // 
            this.Led_Stopbits_ComboBox.FormattingEnabled = true;
            this.Led_Stopbits_ComboBox.ItemHeight = 23;
            this.Led_Stopbits_ComboBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.Led_Stopbits_ComboBox.Location = new System.Drawing.Point(492, 193);
            this.Led_Stopbits_ComboBox.Name = "Led_Stopbits_ComboBox";
            this.Led_Stopbits_ComboBox.Size = new System.Drawing.Size(87, 29);
            this.Led_Stopbits_ComboBox.TabIndex = 12;
            this.Led_Stopbits_ComboBox.UseSelectable = true;
            // 
            // Led_BaudRate_ComboBox
            // 
            this.Led_BaudRate_ComboBox.FormattingEnabled = true;
            this.Led_BaudRate_ComboBox.ItemHeight = 23;
            this.Led_BaudRate_ComboBox.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.Led_BaudRate_ComboBox.Location = new System.Drawing.Point(213, 193);
            this.Led_BaudRate_ComboBox.Name = "Led_BaudRate_ComboBox";
            this.Led_BaudRate_ComboBox.Size = new System.Drawing.Size(87, 29);
            this.Led_BaudRate_ComboBox.TabIndex = 11;
            this.Led_BaudRate_ComboBox.UseSelectable = true;
            // 
            // Led_Databits_ComboBox
            // 
            this.Led_Databits_ComboBox.FormattingEnabled = true;
            this.Led_Databits_ComboBox.ItemHeight = 23;
            this.Led_Databits_ComboBox.Items.AddRange(new object[] {
            "7",
            "8"});
            this.Led_Databits_ComboBox.Location = new System.Drawing.Point(306, 193);
            this.Led_Databits_ComboBox.Name = "Led_Databits_ComboBox";
            this.Led_Databits_ComboBox.Size = new System.Drawing.Size(87, 29);
            this.Led_Databits_ComboBox.TabIndex = 10;
            this.Led_Databits_ComboBox.UseSelectable = true;
            // 
            // Led_Parity_ComboBox
            // 
            this.Led_Parity_ComboBox.FormattingEnabled = true;
            this.Led_Parity_ComboBox.ItemHeight = 23;
            this.Led_Parity_ComboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.Led_Parity_ComboBox.Location = new System.Drawing.Point(399, 193);
            this.Led_Parity_ComboBox.Name = "Led_Parity_ComboBox";
            this.Led_Parity_ComboBox.Size = new System.Drawing.Size(87, 29);
            this.Led_Parity_ComboBox.TabIndex = 9;
            this.Led_Parity_ComboBox.UseSelectable = true;
            // 
            // Led_Port_ComboBox
            // 
            this.Led_Port_ComboBox.FormattingEnabled = true;
            this.Led_Port_ComboBox.ItemHeight = 23;
            this.Led_Port_ComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20"});
            this.Led_Port_ComboBox.Location = new System.Drawing.Point(120, 193);
            this.Led_Port_ComboBox.Name = "Led_Port_ComboBox";
            this.Led_Port_ComboBox.Size = new System.Drawing.Size(87, 29);
            this.Led_Port_ComboBox.TabIndex = 8;
            this.Led_Port_ComboBox.UseSelectable = true;
            // 
            // Port_Label
            // 
            this.Port_Label.AutoSize = true;
            this.Port_Label.Location = new System.Drawing.Point(120, 100);
            this.Port_Label.Name = "Port_Label";
            this.Port_Label.Size = new System.Drawing.Size(34, 19);
            this.Port_Label.TabIndex = 13;
            this.Port_Label.Text = "Port";
            // 
            // BaudRate_Label
            // 
            this.BaudRate_Label.AutoSize = true;
            this.BaudRate_Label.Location = new System.Drawing.Point(213, 100);
            this.BaudRate_Label.Name = "BaudRate_Label";
            this.BaudRate_Label.Size = new System.Drawing.Size(65, 19);
            this.BaudRate_Label.TabIndex = 14;
            this.BaudRate_Label.Text = "BaudRate";
            // 
            // Databits_Label
            // 
            this.Databits_Label.AutoSize = true;
            this.Databits_Label.Location = new System.Drawing.Point(306, 100);
            this.Databits_Label.Name = "Databits_Label";
            this.Databits_Label.Size = new System.Drawing.Size(56, 19);
            this.Databits_Label.TabIndex = 15;
            this.Databits_Label.Text = "DataBits";
            // 
            // Parity_Label
            // 
            this.Parity_Label.AutoSize = true;
            this.Parity_Label.Location = new System.Drawing.Point(399, 100);
            this.Parity_Label.Name = "Parity_Label";
            this.Parity_Label.Size = new System.Drawing.Size(41, 19);
            this.Parity_Label.TabIndex = 16;
            this.Parity_Label.Text = "Parity";
            // 
            // Stopbits_Label
            // 
            this.Stopbits_Label.AutoSize = true;
            this.Stopbits_Label.Location = new System.Drawing.Point(492, 100);
            this.Stopbits_Label.Name = "Stopbits_Label";
            this.Stopbits_Label.Size = new System.Drawing.Size(56, 19);
            this.Stopbits_Label.TabIndex = 17;
            this.Stopbits_Label.Text = "StopBits";
            // 
            // Serial_Save_Button
            // 
            this.Serial_Save_Button.Location = new System.Drawing.Point(411, 304);
            this.Serial_Save_Button.Name = "Serial_Save_Button";
            this.Serial_Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Serial_Save_Button.TabIndex = 18;
            this.Serial_Save_Button.Text = "저장";
            this.Serial_Save_Button.UseSelectable = true;
            this.Serial_Save_Button.Click += new System.EventHandler(this.Serial_Save_Button_Click);
            // 
            // Serial_Close_Button
            // 
            this.Serial_Close_Button.Location = new System.Drawing.Point(502, 304);
            this.Serial_Close_Button.Name = "Serial_Close_Button";
            this.Serial_Close_Button.Size = new System.Drawing.Size(75, 23);
            this.Serial_Close_Button.TabIndex = 19;
            this.Serial_Close_Button.Text = "닫기";
            this.Serial_Close_Button.UseSelectable = true;
            this.Serial_Close_Button.Click += new System.EventHandler(this.Serial_Close_Button_Click);
            // 
            // SerialSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.Serial_Close_Button);
            this.Controls.Add(this.Serial_Save_Button);
            this.Controls.Add(this.Stopbits_Label);
            this.Controls.Add(this.Parity_Label);
            this.Controls.Add(this.Databits_Label);
            this.Controls.Add(this.BaudRate_Label);
            this.Controls.Add(this.Port_Label);
            this.Controls.Add(this.Led_Stopbits_ComboBox);
            this.Controls.Add(this.Led_BaudRate_ComboBox);
            this.Controls.Add(this.Led_Databits_ComboBox);
            this.Controls.Add(this.Led_Parity_ComboBox);
            this.Controls.Add(this.Led_Port_ComboBox);
            this.Controls.Add(this.Indicator_Stopbits_ComboBox);
            this.Controls.Add(this.Indicator_BaudRate_ComboBox);
            this.Controls.Add(this.Indicator_Databits_ComboBox);
            this.Controls.Add(this.Indicator_Parity_ComboBox);
            this.Controls.Add(this.Indicator_Port_ComboBox);
            this.Controls.Add(this.Led_Label);
            this.Controls.Add(this.Indicator_Label);
            this.Name = "SerialSettingForm";
            this.Text = "통신설정";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SerialSettingForm_FormClosed);
            this.Load += new System.EventHandler(this.SerialSettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel Indicator_Label;
        private MetroFramework.Controls.MetroLabel Led_Label;
        private MetroFramework.Controls.MetroComboBox Indicator_Port_ComboBox;
        private MetroFramework.Controls.MetroComboBox Indicator_Parity_ComboBox;
        private MetroFramework.Controls.MetroComboBox Indicator_Databits_ComboBox;
        private MetroFramework.Controls.MetroComboBox Indicator_BaudRate_ComboBox;
        private MetroFramework.Controls.MetroComboBox Indicator_Stopbits_ComboBox;
        private MetroFramework.Controls.MetroComboBox Led_Stopbits_ComboBox;
        private MetroFramework.Controls.MetroComboBox Led_BaudRate_ComboBox;
        private MetroFramework.Controls.MetroComboBox Led_Databits_ComboBox;
        private MetroFramework.Controls.MetroComboBox Led_Parity_ComboBox;
        private MetroFramework.Controls.MetroComboBox Led_Port_ComboBox;
        private MetroFramework.Controls.MetroLabel Port_Label;
        private MetroFramework.Controls.MetroLabel BaudRate_Label;
        private MetroFramework.Controls.MetroLabel Databits_Label;
        private MetroFramework.Controls.MetroLabel Parity_Label;
        private MetroFramework.Controls.MetroLabel Stopbits_Label;
        private MetroFramework.Controls.MetroButton Serial_Save_Button;
        private MetroFramework.Controls.MetroButton Serial_Close_Button;
    }
}