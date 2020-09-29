using StringCalculator.Configuration;
using Xunit;

namespace StringCalculator.Test.Configuration
{
    public class ConfigurationReaderTest
    {
        public ConfigurationReaderTest()
        {
            // Read the appsettings.json
            var configurationReader = new ConfigurationReader();
            configurationReader.GetConfigurationValues();
        }

        [Fact]
        public void GetConfigurationValues_WhenCalled_AssignValuesToConfigurationValues()
        {
            //Arrange
            var configurationReader = new ConfigurationReader();

            //Act
            configurationReader.GetConfigurationValues();

            // Values from appsettings.json
            /* 
               "startingDelimiter": "//",
               "delimiter": ";",
               "lineBreak": "\\\\n",
               "validationBaseRule": "((-?\\d+);(-?\\d+))+"
             */

            //Assert
            Assert.Equal("//", ConfigurationValues.StartingDelimiter);
            Assert.Equal(";", ConfigurationValues.Delimiter);
            Assert.Equal("\\\\n", ConfigurationValues.LineBreak);
            Assert.Equal("((-?\\d+);(-?\\d+))+", ConfigurationValues.ValidationBaseRule);
        }
    }
}
