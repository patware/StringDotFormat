using System;
using System.Collections.Generic;
using System.Text;

namespace StringDotFormat
{
    public enum FormatType
    {
        StringFormat,
        ToString
    }
    abstract class dataType
    {
        public string[] StandardStringFormats;
        public string[] CustomStringFormats;

        public abstract string Format(string inputValue, FormatType formatType, string formatString);

    }
}
