using StringCalculator.Configuration;
using StringCalculator.Validators;
using Xunit;

namespace StringCalculator.Test.Validators
{
   
    public class StringValidatorTest
    {
        private readonly StringValidator _sut;

        public StringValidatorTest()
        {
            // Read the appsettings.json before parsing.
            var configurationReader = new ConfigurationReader();
            configurationReader.GetConfigurationValues();

            //Arrange
            _sut = new StringValidator();
        }

        [Fact]
        public void IsValid_WhenCalled_withValidInputs_ReturnsTrue()
        {
            //Act
            var validationResult1 = _sut.IsValid("//;\\n1;2");   // Positive numbers
            var validationResult2 = _sut.IsValid("//;\\n-1;-2"); // Negative numbers 

            //Assert
            Assert.True(validationResult1);
            Assert.True(validationResult2);
        }

        [Fact]
        public void IsValid_WhenCalled_withInvalidInputs_ReturnsFalse()
        {
            //Act
            var validationResult = _sut.IsValid("1,\\n");  

            //Assert
            Assert.False(validationResult);
        }
    }
}
