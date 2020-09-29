using System.Collections.Generic;
using StringCalculator.Exceptions;
using Xunit;

namespace StringCalculator.Test.Exceptions
{
    public class ParsingExceptionsTest
    {
        private readonly ParsingExceptions _sut;
        public ParsingExceptionsTest()
        {
            _sut = new ParsingExceptions();
        }

        [Fact]
        public void HasAnyNegative_WhenCalled_ReturnsFalse()
        {
            //Arrange
            var list = new List<int>{ 1, 2, 3 };
            
            //Act
            var result = _sut.HasAnyNegative(list);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void HasAnyNegative_WhenCalled_ReturnsTrue()
        {
            //Arrange
            var list = new List<int> { -3, -10 };
           
            //Act
            var result = _sut.HasAnyNegative(list);

            //Assert
            Assert.True(result);
        }
    }
}
