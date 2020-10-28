using Xunit;

namespace Practice.Tests
{
    public class FibonacciTests
    {
        [Fact]
        public void PositionEqualsZero_ShouldReturnZero()
        {
            Assert.Equal(0, Fibonacci.GetFibonacci(0));
        }

        [Fact]
        public void PositionEqualsOne_ShouldReturnOne()
        {
            Assert.Equal(1, Fibonacci.GetFibonacci(1));
        }

        [Fact]
        public void PositionEqualsTwo_ShouldReturnOne()
        {
            Assert.Equal(1, Fibonacci.GetFibonacci(2));
        }

        [Fact]
        public void PositionEqualsFive_ShouldReturnFive()
        {
            Assert.Equal(5, Fibonacci.GetFibonacci(5));
        }
    }
}
