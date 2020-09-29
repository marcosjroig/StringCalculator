using System.Text;
using System.Text.RegularExpressions;
using StringCalculator.Configuration;

namespace StringCalculator.Validators
{
    public class StringValidator: IStringValidator
    {
        public bool IsValid(string input)
        {
            //Example pattern => @"//;\\n((-?\d+);(-?\d+))+";
            var pattern = new StringBuilder();
            pattern.Append(ConfigurationValues.StartingDelimiter);
            pattern.Append(ConfigurationValues.Delimiter);
            pattern.Append(ConfigurationValues.LineBreak);
            pattern.Append(ConfigurationValues.ValidationBaseRule);
            
            // Match input and pattern
            var match = Regex.Match(input, pattern.ToString(), RegexOptions.IgnoreCase);

            // Math result: will return true if there is a valid input and false if not.
            return match.Success;
        }
    }
}
