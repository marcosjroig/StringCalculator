using StringCalculator.Configuration;
using StringCalculator.Numbers;
using Xunit;

namespace StringCalculator.Test.Numbers
{
    public class NumberParserTest
    {
        public NumberParserTest()
        {
            // Read the appsettings.json before parsing.
            var configurationReader = new ConfigurationReader();
            configurationReader.GetConfigurationValues();
        }

        [Fact]
        public void GetNumbers_WhenCalled_ReturnsListOfNumbers()
        {
            //Arrange
            var sut = new NumberParser();

            //Act
            var list1 = sut.GetNumbers("//;\\n1;2");   // Positive numbers
            var list2 = sut.GetNumbers("//;\\n-1;-2"); // Negative numbers 

            //Assert
            Assert.Equal(2, list1.Count);
            Assert.Equal(1, list1[0]);
            Assert.Equal(2, list2.Count);
            Assert.Equal(-1, list2[0]);
        }
    }
}
