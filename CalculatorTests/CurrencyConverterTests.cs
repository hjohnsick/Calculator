using Xunit;

namespace Practice.Tests
{
    public class CurrencyConverterTests
    {
        [Fact]
        public void USD_to_EU_ShouldConvert()
        {
            var sut = new CurrencyConverter();

            var expected = 94;
            var actual = sut.USD_to_EU(100);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void USD_to_GBP_ShouldConvert()
        {
            var sut = new CurrencyConverter();

            var expected = 67.15;
            var actual = sut.USD_to_GBP(85);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void USD_to_JPY_ShouldConvert()
        {
            var sut = new CurrencyConverter();

            var expected = 8537.15;
            var actual = sut.USD_to_JPY(75.55);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void USD_to_CAD()
        {
            var sut = new CurrencyConverter();

            var expected = 33.25;
            var actual = sut.USD_to_CAD(25);

            Assert.Equal(expected, actual);
        }
    }
}
