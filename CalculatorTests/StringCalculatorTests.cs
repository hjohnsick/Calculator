using System;
using Xunit;

namespace Practice.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Add_EmptyStringAsParam_ReturnZero()
        {
            Assert.Equal(0, StringCalculator.Add(string.Empty));
        }

        [Fact]
        public void Add_StringContainingSingleNumber_ReturnsTheNumberItself()
        {
            Assert.Equal(5, StringCalculator.Add("5"));
        }

        [Fact]
        public void Add_TwoNumbersSeparatedByComma_ReturnsTheirSum()
        {
            var numbers = "7, 8";
            var expectedResult = 15;
            Assert.Equal(expectedResult, StringCalculator.Add(numbers));
        }

        [Fact]
        public void Add_ThreeNumbersSeparatedByComma_ReturnsTheirSum()
        {
            var numbers = "1, 2, 3";
            var expectedResult = 6;

            Assert.Equal(expectedResult, StringCalculator.Add(numbers));
        }

        [Theory]
        [InlineData("1, 2, 3, 4", 10)]
        [InlineData("8, 7, 20", 35)]
        [InlineData("5, 0, 4, 1000", 1009)]
        [InlineData("26, 6, 90", 122)]
        public void Add_MoreThanThreeNumbersSepartedByComma_ReturnsTheirSum(string input, int result)
        {
            Assert.Equal(result, StringCalculator.Add(input));
        }

        [Theory]
        [InlineData("1, 2, 3, 4, 5, -5")]
        [InlineData("-1, 1, 2, 9")]
        [InlineData("5, 6, 8, -5")]
        public void Add_StringContainingNegativeNumbers_Throws(string numbers)
        {
            Assert.Throws<ArgumentException>(() => StringCalculator.Add(numbers));
        }
    }
}
