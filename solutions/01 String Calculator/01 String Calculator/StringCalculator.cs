using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_String_Calculator
{
    public class StringCalculator
    {
        public int Calculate(string str)
        {
            var isDelimiterSpecified = str.StartsWith("//");
            string[] delimiters;
            if (isDelimiterSpecified)
            {
                var hasMultiCharOpening = str[2] == '[';
                var multiCharClosingPos = str.IndexOf(']');
                var isMultiCharDelimiterSpecified = hasMultiCharOpening && multiCharClosingPos >= 4;
                var delimiterStartPos = isMultiCharDelimiterSpecified ? 3 : 2;
                var length = isMultiCharDelimiterSpecified ? multiCharClosingPos - 3 : 1;
                var strStartPos = isMultiCharDelimiterSpecified ? multiCharClosingPos + 1 : 3;
                delimiters = new[] { str.Substring(delimiterStartPos, length) };
                str = str.Substring(strStartPos);
            }
            else
            {
                delimiters = new[] {",", "\n"};
            }

            var numbers = str
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n <= 1000)
                .ToList();

            if (numbers.Exists(n => n < 0))
            {
                throw new Exception();
            }

            return numbers
                .Sum();
        }
    }
}
