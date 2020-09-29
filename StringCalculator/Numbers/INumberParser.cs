using System.Collections.Generic;

namespace StringCalculator.Numbers
{
    public interface INumberParser
    {
        List<int> GetNumbers(string input);
    }
}
