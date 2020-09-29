using System;
using System.Collections.Generic;

namespace StringCalculator.Calculations
{
    public class Calculator: ICalculator
    {
        private readonly ISum _sum;

        public Calculator(ISum sum)
        {
            this._sum = sum;
        }
        public void ExecuteOperations(List<int> numberList)
        {
            // Declare delegate
            Func<List<int>, int> operations = _sum.Execute;

            // Trigger delegate
            operations(numberList);
        }
    }
}
