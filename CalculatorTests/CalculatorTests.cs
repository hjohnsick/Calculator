using Calculations;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(21, 5.25, 26.25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            //Arrange
             

            //Act
            double actual = Calculator.Add(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subtract_SimpleValuesShouldCalculate()
        {
            //Arrange
            double expected = 44.67;

            //Act
            double actual = Calculator.Subtract(100, 55.33);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multipy_SimpleValuesShouldCalculate()
        {
            //Arrange
            double expected = 123.9625;

            //Act
            double actual = Calculator.Multiply(10.55, 11.75);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 2)]
        public void Division_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            //Arrange
            

            //Act
            double actual = Calculator.Divide(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]      
        public void Divide_DivideByZero()
        {
            //Arrange
            double expected = 0;

            //Act
            double actual = Calculator.Divide(8, 0);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, 11.3, 2.1, 66.777)]
        public void AverageOfFourNumbers_ShouldReturnAverage(double num1, double num2, double num3, double num4)
        {
            var expected = 23.79425;

            var actual = Calculator.AverageOfFourNumbers(num1, num2, num3, num4);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 11.5, 2)]
        public void FindMaxNum_ShouldReturnLargestNumber(double num1, double num2, double num3)
        {
            var expected = 11.5;

            var actual = Calculator.FindMaxNum(num1, num2, num3);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 55, 0, 0)]
        [InlineData(2.2, 88, 2.5, 2.2)]
        public void FindMinNum_ShouldReturnSmallestNumber(double num1, double num2, double num3, double expected)
        {

            var actual = Calculator.FindMinNum(num1, num2, num3);

            Assert.Equal(expected, actual);

        }
    }
}
