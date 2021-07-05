using System;
using Xunit;

namespace Session23ClassLibrary.Tests
{
    public class FibonacciTest
    {
        private Fibonacci CreateDefaultSUT()
        {
            var sut = new Fibonacci();
            return sut;
        }

        //[Fact]
        [Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(15,610)]

        public void FibonacciSeries_ZeroOrPositiveNumberIsGivenWithinRange_ReturnsTotalValueCorrectly(long n,long expected)
        {
            var fib = CreateDefaultSUT();

            var actual = fib.FibonacciSeries(n);

            Assert.Equal(expected, actual);

        }

        [Fact]

        public void FibonacciSeries_NegativeArgumentIsGiven_ThrowsArgumentException()
        {
            var fib = CreateDefaultSUT();

            var actualN = -3;

            Assert.Throws<ArgumentException>(() =>
            {
                var actual = fib.FibonacciSeries(actualN);
            });
        }

        [Fact]

        public void FibonacciSeries_ArgumentIsGivenHigherThanExpected_ThrowsArgumentException()
        {
            var fib = CreateDefaultSUT();

            var actualN = 95;

            Assert.Throws<ArgumentException>(() =>
            {
                var actual = fib.FibonacciSeries(actualN);
            });
        }

    }
}
