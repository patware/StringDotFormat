using System;
using System.Collections.Generic;
using System.Text;

namespace StringDotFormat
{
    class DataTypeFloating : DataType
    {
        public DataTypeFloating()
        {
			base.StandardStringFormats =
				new string[]
                {
                    "C - Currency",
                    "D - Decimal",
                    "E - Scientific (exponential)",
                    "F - Fixed-point",
                    "G - General",
                    "N - Number",
                    "P - Percent",
                    "R - Round-trip",
                    "X - Hexadecimal"
                };
			base.CustomStringFormats =
				new string[]
                {
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
                    "Other - All other characters"
                };
        }
        public override string Format(string inputValue, FormatType formatType, string formatString)
        {
            string result="";

            float f;
            float.TryParse(inputValue, out f);

            switch (formatType)
            {
                case FormatType.ToString:
                    result = f.ToString(formatString);
                    break;
                case FormatType.StringFormat:
                    result = string.Format(formatString, f);
                    break;
            }

            return result;
        }
    }
}
