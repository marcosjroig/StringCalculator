using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.Exceptions
{
    public class ParsingExceptions: IParsingExceptions
    {
        public bool HasAnyNegative(List<int> numberList)
        {
            var result = numberList.Any(x => x < 0);

            if (result)
            {
                DisplayNegatives( numberList);
            }
            return result;
        }

        private void DisplayNegatives(List<int> numberList)
        {
            var listStr = string.Join(",", numberList.ToArray());
            Console.WriteLine($"The list '{listStr}' has negative values.");
            foreach (var number in numberList)
            {
                // I am not throwing the exception, I am just displaying the error.
                Console.WriteLine($"   --> Negative number found: {number}");
            }
        }
    }
}
