using System.Collections.Generic;

namespace StringCalculator.Calculations
{
    public interface ICalculator
    {
        void ExecuteOperations(List<int> numberList);
    }
}
