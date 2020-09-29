using System.Collections.Generic;
using System.Text.RegularExpressions;
using StringCalculator.Configuration;

namespace StringCalculator.Numbers
{
    public class NumberParser: INumberParser
    {
        public List<int> GetNumbers(string input)
        {
            var numberList = new List<int>();

            // Get all matches.
            var matches = Regex.Matches(input, ConfigurationValues.NumbersPattern);

            foreach (Match match in matches)
            {
                foreach (Capture capture in match.Captures)
                {
                    // Add the number to the list
                    numberList.Add( int.Parse(capture.Value));
                }
            }

            return numberList;
        }
    }
}
