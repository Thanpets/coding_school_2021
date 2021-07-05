using System;

namespace Session23ClassLibrary
{
    public class Fibonacci : IFibonacciCalculator
    {
        public long FibonacciSeries(long n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (90 > n && n > 1)
            {
                return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
            }
            if (n < 0) throw new ArgumentException("Invalid input", nameof(n));
            throw new ArgumentException("Fibonacci result number too big", nameof(n));

        }
    }
}
