using System;
using System.Collections.Generic;
using System.Text;

namespace StringDotFormat
{
    class GenericDisplay<T>
    {
        ulong _value;

        public GenericDisplay()
        {
        }
        public string toString(string format)
        {
            return _value.ToString();
        }
           
        public string formatString(string formatString)
        {
            return string.Format(formatString, _value);
        }
    }
}
