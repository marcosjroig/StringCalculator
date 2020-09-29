using System.Collections.Generic;
using StringCalculator.Configuration;
using StringCalculator.Ignore;
using Xunit;

namespace StringCalculator.Test.Ignore
{
    public class IgnoreNumbersTest
    {
        private readonly IgnoreNumbers _sut;
        public IgnoreNumbersTest()
        {
            // Read the appsettings.json
            var configurationReader = new ConfigurationReader();
            configurationReader.GetConfigurationValues();

            _sut = new IgnoreNumbers();
        }

        [Fact]
        public void Remove_WhenCalled_WillRemoveOneElement()
        {
            //Arrange
            var list = new List<int> { 1001, 2, 3 }; // 1001 will be removed

            //Act
            _sut.Remove(list);

            //Assert
            Assert.Equal(2, list.Count);
        }

        [Fact]
        public void Remove_WhenCalled_WillNotRemoveAnyElement()
        {
            //Arrange
            var list = new List<int> { 2, 3, 4};

            //Act
            _sut.Remove(list);

            //Assert
            Assert.Equal(3, list.Count);
        }
    }
}
