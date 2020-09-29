using System.IO;
using Microsoft.Extensions.Configuration;

namespace StringCalculator.Configuration
{
    public class ConfigurationReader: IConfigurationReader
    {
        public void GetConfigurationValues()
        {
            var configuration = BuildConfiguration();

            ConfigurationValues.StartingDelimiter = configuration.GetSection("startingDelimiter").Value;
            ConfigurationValues.Delimiter = configuration.GetSection("delimiter").Value;
            ConfigurationValues.LineBreak = configuration.GetSection("lineBreak").Value;
            ConfigurationValues.ValidationBaseRule = configuration.GetSection("validationBaseRule").Value;
            ConfigurationValues.NumbersPattern = configuration.GetSection("numbersPattern").Value;
            ConfigurationValues.MaxNumber = configuration.GetSection("maxNumber").Value;
        }

        private IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            return configuration;
        }
    }
}
