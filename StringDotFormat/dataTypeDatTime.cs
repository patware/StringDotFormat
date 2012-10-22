using System;
using System.Collections.Generic;
using System.Text;

namespace StringDotFormat
{
    class dataTypeDatTime:dataType
    {
        public dataTypeDatTime()
        {
            base.StandardStringFormats =
                            new string[]
                {
                    "d - short date pattern",
                    "D - long date pattern",
                    "t - short time pattern",
                    "T - long time pattern",
                    "f - full date/time pattern (short time)",
                    "F - full date/time pattern (long time)",
                    "g - general date/time pattern (short time)",
                    "G - general date/time pattern (long time)",
                    "M - Month day pattern",
                    "m - Month day pattern",
                    "R - RFC1123 pattern",
                    "r - RFC1123 pattern",
                    "s - sortable date/time (ISO 8601)",
                    "u - universal sortable date/time pattern",
                    "U - universal sortable date/time pattern",
                    "Y - year month pattern",
                    "y - year month pattern"
                };

            base.CustomStringFormats =
                new string[]
                {
                   
                    "d - day of month",
                    "dd - day of month (with preceding 0)",
                    "ddd - abbreviated day",
                    "dddd - full name of day",
                    "f - 1 digit fraction",
                    "ff - 2 digits fraction",
                    "fff - 3 digits fraction",
                    "ffff - 4 digits fraction",
                    "fffff - 5 digits fraction",
                    "ffffff - 6 digits fraction",
                    "fffffff - 7 digits fraction",
                    "F - 1 digit fraction, no trailing",
                    "FF - 2 digits fraction, no trailing",
                    "FFF - 3 digits fraction, no trailing",
                    "FFFF - 4 digits fraction, no trailing",
                    "FFFFF - 5 digits fraction, no trailing",
                    "FFFFFF - 6 digits fraction, no trailing",
                    "FFFFFFF - 7 digits fraction, no trailing",
                    "g - era",
                    "gg - era",
                    "h - hour (1-12)",
                    "hh - hour (1-12 ) with preceding 0",
                    "H - hour (1-24)",
                    "HH - hour (1-24) with preceding 0",
                    "m - minutes (0-59)",
                    "mm - minutes (0-59 with preceding 0",
                    "M - month (1-12)",
                    "MM - month (1-12) with preceding 0",
                    "MMM - abbreviated month name",
                    "MMMM - month name",
                    "s - seconds (0-59)",
                    "ss - seconds (0-59) with preceding 0",
                    "t - A/P",
                    "tt - AM/PM",
                    "y - year (max 2 digits)",
                    "yy - year (max 2 digits) with preceding 0",
                    "yyyy - year (4 digits)",
                    "z - time zone offset",
                    "zz - time zone offset with preceding 0",
                    "zzz - time zone offset",
                    ": - time separator",
                    "/ - date separator",
                    "\"Literal\" - litteral value",
                    "'Literal' - litteral value",
                    "%c - custom format",
                    "\\c - escape",
                    "anyother - any other"
                };
        }
        public override string Format(string inputValue, FormatType formatType, string formatString)
        {
            string result = "";

            DateTime dt;
            DateTime.TryParse(inputValue, out dt);

            switch (formatType)
            {
                case FormatType.ToString:
                    result = dt.ToString(formatString);
                    break;
                case FormatType.StringFormat:
                    result = string.Format(formatString, dt);
                    break;
            }

            return result;
        }
    }
}
