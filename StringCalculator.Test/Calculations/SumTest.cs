using System.Collections.Generic;
using StringCalculator.Calculations;
using Xunit;

namespace StringCalculator.Test.Calculations
{
    public class SumTest
    {
        [Fact]
        public void Execute_WhenCalled_ReturnsTheSum()
        {
            //Arrange
            var list1 = new List<int>() {1, 2, 3};
            var list2 = new List<int>() {50, 50};
            var sut = new Sum();

            //Act
            var result1 = sut.Execute(list1);  
            var result2 = sut.Execute(list2); 

            //Assert
            Assert.Equal(6, result1);
            Assert.Equal(100, result2);
        }
    }
}
