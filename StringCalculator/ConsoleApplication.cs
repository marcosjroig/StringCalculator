using StringCalculator.Configuration;
using StringCalculator.Calculations;

namespace StringCalculator
{
    public class ConsoleApplication
    {
        private readonly IConfigurationReader _configurationReader;
        private readonly ICalculation _calculation;
        public ConsoleApplication(IConfigurationReader configurationReader, ICalculation calculation)
        {
            _configurationReader = configurationReader;
            _calculation = calculation;
        }
        public void Run()
        {
            // Read the configuration: appsettings.json
            _configurationReader.GetConfigurationValues();

            _calculation.Execute("//;\\n1;2");   // Expecting 3
            _calculation.Execute("//;\\n-1;-2"); // No result as it has negatives 
            _calculation.Execute("1,\\n");       // Invalid input 
            _calculation.Execute("//;\\n1000;50;150"); //1000 will be ignored as the rule allows all numbers from 0 to 999. Expecting 200
        }
    }
}
