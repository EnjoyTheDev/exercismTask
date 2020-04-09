using System;
using System.Collections.Generic;
using System.Linq;

public static class Grains
{
    public static int grain = 1;

    public static ulong Square(int n)
    {
        if (n <= 0 || n > 64)
        {
            throw new ArgumentOutOfRangeException();
        }
        return (ulong)Math.Pow(2, n - 1);
    }

    public static ulong Total()
    {
        IEnumerable<ulong> square = Enumerable.Range(1, 64).Select(i => (ulong)Math.Pow(2, i - 1));
        ulong total = square.Aggregate((a, b) => a + b);
        return total;
    }
}