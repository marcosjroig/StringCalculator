using System.Collections.Generic;

namespace StringCalculator.Exceptions
{
    public interface IParsingExceptions
    {
        bool HasAnyNegative(List<int> numberList);
    }
}
