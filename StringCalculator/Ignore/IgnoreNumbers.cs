using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using StringCalculator.Configuration;

namespace StringCalculator.Ignore
{
    public class IgnoreNumbers: IIgnoreNumbers
    {
        public void Remove(List<int> numberList)
        {
            foreach (var number in numberList.ToList())
            {
                var match = Regex.Match(number.ToString(), ConfigurationValues.IgnoreRule);

                if (match.Success)
                {
                    numberList.RemoveAll(item => item == number);
                }
            }
        }
    }
}
