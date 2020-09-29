using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.Calculations
{
    public class Sum: ISum
    {
        public int Execute(List<int> numberList)
        {
            var result = numberList.Sum();
            var listStr = string.Join(",", numberList.ToArray());
            Console.WriteLine($"The result for the list '{listStr}' is: {result}");

            return result;
        }
    }
}
