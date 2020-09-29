using System;
using StringCalculator.Exceptions;
using StringCalculator.Ignore;
using StringCalculator.Numbers;
using StringCalculator.Validators;

namespace StringCalculator.Calculations
{
    public class Calculation: ICalculation
    {
        private readonly IStringValidator _stringValidator;
        private readonly INumberParser _numberParser;
        private readonly ICalculator _calculator;
        private readonly IParsingExceptions _parsingExceptions;
        private readonly IIgnoreNumbers _ignoreNumbers;

        public Calculation(IStringValidator stringValidator, INumberParser numberParser, ICalculator calculator, IParsingExceptions parsingExceptions, IIgnoreNumbers ignoreNumbers)
        {
            _stringValidator = stringValidator;
            _numberParser = numberParser;
            _calculator = calculator;
            _parsingExceptions = parsingExceptions;
            _ignoreNumbers = ignoreNumbers;
        }
        public void Execute(string input)
        {
            if (_stringValidator.IsValid(input))
            {
                // Step 1: get the list of numbers
                var numberList = _numberParser.GetNumbers(input);

                // Step 2: Check negative numbers
                var hasAnyNegative = _parsingExceptions.HasAnyNegative(numberList);

                if (!hasAnyNegative)
                {
                    // Step 3: Check ignore list
                    _ignoreNumbers.Remove(numberList);

                    // Step 4: execute the calculator
                    _calculator.ExecuteOperations(numberList);
                }
            }
            else
            {
                Console.WriteLine($"The input '{input}' is not valid.");
            }
        }
    }
}
