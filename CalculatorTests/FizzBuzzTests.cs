using System;
using Xunit;

namespace Practice.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void GivenOneExpectOne()
        {
            var expected = 1;
            var actual = FizzBuzz.PrintNumbersOrFizzBuzz(expected);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenThreeExpectFizz()
        {
            var expected = "Fizz";
            var actual = FizzBuzz.PrintNumbersOrFizzBuzz(3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenFiveExpectBuzz()
        {
            var expected = "Buzz";
            var actual = FizzBuzz.PrintNumbersOrFizzBuzz(5);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenFifteenExpectFizzBuzz()
        {
            var expected = "FizzBuzz";
            var actual = FizzBuzz.PrintNumbersOrFizzBuzz(15);

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ShouldThrowException()
        {
            
            Assert.Throws<IndexOutOfRangeException>(() => FizzBuzz.PrintNumbersOrFizzBuzz(-1));
        }
    }
}
