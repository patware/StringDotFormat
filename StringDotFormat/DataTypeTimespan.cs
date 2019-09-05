using System;

namespace StringDotFormat
{
	class DataTypeTimespan : DataType
	{
		public DataTypeTimespan()
		{
			base.StandardStringFormats = new string[]
			{
				"c - Constant (invariant) format",
				"g - General short format",
				"G - General long format"
			};

			base.CustomStringFormats = new string[]
			{
				"d - The number of whole days in the time interval.",
				"dd..dddddddd - The number of whole days in the time interval, padded with leading zeros as needed.",
				"h - The number of whole hours in the time interval that aren't counted as part of days. Single-digit hours don't have a leading zero.",
				"hh - The number of whole hours in the time interval that aren't counted as part of days. Single-digit hours have a leading zero.",
				"m - The number of whole minutes in the time interval that aren't included as part of hours or days. Single-digit minutes don't have a leading zero.",
				"mm - The number of whole minutes in the time interval that aren't included as part of hours or days. Single-digit minutes have a leading zero.",
				"s - The number of whole seconds in the time interval that aren't included as part of hours, days, or minutes. Single-digit seconds don't have a leading zero.",
				"ss - The number of whole seconds in the time interval that aren't included as part of hours, days, or minutes. Single-digit seconds have a leading zero.",
				"f - The tenths of a second in a time interval.",
				"ff - The hundredths of a second in a time interval.",
				"fff - The milliseconds in a time interval.",
				"ffff - The ten-thousandths of a second in a time interval.",
				"fffff - The hundred-thousandths of a second in a time interval.",
				"ffffff - The millionths of a second in a time interval.",
				"fffffff - The ten-millionths of a second (or the fractional ticks) in a time interval.",
				"F - The tenths of a second in a time interval. Nothing is displayed if the digit is zero.",
				"FF - The hundredths of a second in a time interval. Any fractional trailing zeros or two zero digits aren't included.",
				"FFF - The milliseconds in a time interval. Any fractional trailing zeros aren't included.",
				"FFFF - The ten-thousandths of a second in a time interval. Any fractional trailing zeros aren't included.",
				"FFFFF - The hundred-thousandths of a second in a time interval. Any fractional trailing zeros aren't included.",
				"FFFFFF - The millionths of a second in a time interval. Any fractional trailing zeros aren't displayed.",
				"FFFFFFF - The ten-millions of a second in a time interval. Any fractional trailing zeros or seven zeros aren't displayed.",
				"'string' - Literal string delimiter.",
				"\\ - The escape character.",
				"Any other character - Any other unescaped character is interpreted as a custom format specifier."
			};

		}

		public override string Format(string inputValue, FormatType formatType, string formatString)
		{
			string result = "";

			var ts = new TimeSpan(11, 12, 13, 14, 15);
			
			switch (formatType)
			{
				case FormatType.ToString:
					result = ts.ToString(formatString);
					break;
				case FormatType.StringFormat:
					result = string.Format(formatString, ts);
					break;
			}

			return result;
		}
	}
}
