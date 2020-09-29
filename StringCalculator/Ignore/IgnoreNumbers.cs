using System.Collections.Generic;
using System.Linq;
using StringCalculator.Configuration;

namespace StringCalculator.Ignore
{
    public class IgnoreNumbers: IIgnoreNumbers
    {
        public void Remove(List<int> numberList)
        {
            foreach (var number in numberList.ToList())
            {
                var maxNumber = int.Parse(ConfigurationValues.MaxNumber);

                if (number > maxNumber)
                {
                    numberList.RemoveAll(item => item == number);
                }
            }
        }
    }
}
