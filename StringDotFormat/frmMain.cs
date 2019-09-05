using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StringDotFormat
{
    public partial class frmMain : Form
    {
        private List<DataType> _dataTypes = new List<DataType>();
        private DataType _currentDataType = null;
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtFormatString_TextChanged(object sender, EventArgs e)
        {
            formatIt();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            formatIt();
        }

        private void comDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comDataType.SelectedIndex)
            {
                case -1:
                    _currentDataType = new DataTypeIntegral();
                    break;
                case 0:
                    _currentDataType = new DataTypeIntegral();
                    break;
                case 1:
                    _currentDataType = new DataTypeFloating();
                    break;
                case 2:
                    _currentDataType = new DataTypeDateTime();
					break;
				case 3:
					_currentDataType = new DataTypeDecimal();
					break;
				case 4:
					_currentDataType = new DataTypeTimespan();
					break;

			}

			loadFormatCues();
            
            formatIt();
        }
        private void loadFormatCues()
        {
            this.comTextBoxCustom.Items.Clear();
            this.comTextBoxCustom.Items.AddRange(_currentDataType.CustomStringFormats);

            this.comTextBoxStandard.Items.Clear();
            this.comTextBoxStandard.Items.AddRange(_currentDataType.StandardStringFormats);
        }
        private void formatIt()
        {
            string valueString = this.txtValue.Text;
            string stringFormat = this.txtFormatString.Text;
            string toStringFormat = this.txtTextBoxFormat.Text;
            string result = "";

            try
            {

                switch(this.tabControl1.SelectedIndex)
                {
                    case 0:
                        result = _currentDataType.Format(valueString, FormatType.ToString, toStringFormat);
                        break;
                    case 1:
                        result = _currentDataType.Format(valueString, FormatType.StringFormat, stringFormat);
                        break;
                }
                
            }
            catch (Exception ex) { result = ex.Message; }
                        
            this.lblResult.Text = result;
            
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

            _currentDataType = new DataTypeIntegral();

        }

        private void comTextBoxStandard_SelectedIndexChanged(object sender, EventArgs e)
        {
            string formatName = comTextBoxStandard.Text.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries)[0];

            this.txtTextBoxFormat.Text = formatName.Trim();
        }

        private void txtTextBoxFormat_TextChanged(object sender, EventArgs e)
        {
            formatIt();
        }

        private void txtFormatString_TextChanged_1(object sender, EventArgs e)
        {
            formatIt();
        }

        private void showHelp()
        {
            this.lblResult.Text = "Enter a value in the value textbox, choose a data type, choose a format string";
        }

        private void comTextBoxCustom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string formatName = this.comTextBoxCustom.Text.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries)[0];

            this.txtTextBoxFormat.Text = formatName.Trim();
            
        }

        

    }
}