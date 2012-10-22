namespace StringDotFormat
{
    partial class frmMain
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtValue = new System.Windows.Forms.TextBox();
			this.comDataType = new System.Windows.Forms.ComboBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.comTextBoxCustom = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comTextBoxStandard = new System.Windows.Forms.ComboBox();
			this.txtTextBoxFormat = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.txtFormatString = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Value";
			// 
			// txtValue
			// 
			this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtValue.Location = new System.Drawing.Point(6, 16);
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(127, 20);
			this.txtValue.TabIndex = 1;
			this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
			// 
			// comDataType
			// 
			this.comDataType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comDataType.FormattingEnabled = true;
			this.comDataType.Items.AddRange(new object[] {
            "Integer",
            "Float",
            "DateTime",
			"Decimal"});
			this.comDataType.Location = new System.Drawing.Point(139, 16);
			this.comDataType.Name = "comDataType";
			this.comDataType.Size = new System.Drawing.Size(158, 21);
			this.comDataType.TabIndex = 3;
			this.comDataType.SelectedIndexChanged += new System.EventHandler(this.comDataType_SelectedIndexChanged);
			// 
			// lblResult
			// 
			this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblResult.BackColor = System.Drawing.Color.Black;
			this.lblResult.ForeColor = System.Drawing.Color.Lime;
			this.lblResult.Location = new System.Drawing.Point(3, 168);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(294, 92);
			this.lblResult.TabIndex = 5;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(6, 43);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(289, 122);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.comTextBoxCustom);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.comTextBoxStandard);
			this.tabPage1.Controls.Add(this.txtTextBoxFormat);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(281, 96);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "TextBox";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Custom Format Strings";
			// 
			// comTextBoxCustom
			// 
			this.comTextBoxCustom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comTextBoxCustom.FormattingEnabled = true;
			this.comTextBoxCustom.Items.AddRange(new object[] {
            "0 - Zero Placeholder",
            "# - Digit Placeholder",
            ". - Decimal point",
            ", - Thousand separator and number scaling",
            "% - Percentage placeholder",
            "E0 - Scientific notation",
            "E+0 - Scientific notation",
            "E-0 - Scientific notation",
            "e0 - Scientific notation",
            "e+0 - Scientific notation",
            "e-0 - Scientific notation",
            "\\ - Escape character",
            "\'ABC\' - Literal string",
            "\"ABC\" - Literal string",
            "; - Section separator (to separate sections for positive, negative, and zero numb" +
                "ers)",
            "Other - All other characters"});
			this.comTextBoxCustom.Location = new System.Drawing.Point(154, 31);
			this.comTextBoxCustom.Name = "comTextBoxCustom";
			this.comTextBoxCustom.Size = new System.Drawing.Size(121, 21);
			this.comTextBoxCustom.TabIndex = 3;
			this.comTextBoxCustom.SelectedIndexChanged += new System.EventHandler(this.comTextBoxCustom_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Standard Format Strings";
			// 
			// comTextBoxStandard
			// 
			this.comTextBoxStandard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comTextBoxStandard.FormattingEnabled = true;
			this.comTextBoxStandard.Items.AddRange(new object[] {
            "C - Currency",
            "D - Decimal",
            "E - Scientific (exponential)",
            "F - Fixed-point",
            "G - General",
            "N - Number",
            "P - Percent",
            "R - Round-trip",
            "X - Hexadecimal"});
			this.comTextBoxStandard.Location = new System.Drawing.Point(154, 6);
			this.comTextBoxStandard.Name = "comTextBoxStandard";
			this.comTextBoxStandard.Size = new System.Drawing.Size(121, 21);
			this.comTextBoxStandard.TabIndex = 1;
			this.comTextBoxStandard.SelectedIndexChanged += new System.EventHandler(this.comTextBoxStandard_SelectedIndexChanged);
			// 
			// txtTextBoxFormat
			// 
			this.txtTextBoxFormat.Location = new System.Drawing.Point(45, 70);
			this.txtTextBoxFormat.Name = "txtTextBoxFormat";
			this.txtTextBoxFormat.Size = new System.Drawing.Size(175, 20);
			this.txtTextBoxFormat.TabIndex = 4;
			this.txtTextBoxFormat.TextChanged += new System.EventHandler(this.txtTextBoxFormat_TextChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.txtFormatString);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(281, 96);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Format String";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 75);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(180, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Tip: {index[,alignment][:formatString]}";
			// 
			// txtFormatString
			// 
			this.txtFormatString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtFormatString.Location = new System.Drawing.Point(11, 19);
			this.txtFormatString.Multiline = true;
			this.txtFormatString.Name = "txtFormatString";
			this.txtFormatString.Size = new System.Drawing.Size(264, 47);
			this.txtFormatString.TabIndex = 1;
			this.txtFormatString.Text = "This is a {0,10:0.0} sample";
			this.txtFormatString.TextChanged += new System.EventHandler(this.txtFormatString_TextChanged_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Format string";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(136, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Data Type";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(299, 262);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.comDataType);
			this.Controls.Add(this.txtValue);
			this.Controls.Add(this.label2);
			this.MinimumSize = new System.Drawing.Size(307, 288);
			this.Name = "frmMain";
			this.Text = "StringDotFormat - by Patware";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox comDataType;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtTextBoxFormat;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtFormatString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comTextBoxStandard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comTextBoxCustom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

