using System;
using System.Linq;

namespace CodingGameKatas
{
    public static class ClosestToZeroKata
    {
        public static int ClosestToZero(int[] numbers)
        {
            if (numbers?.Any() != true)
            {
                return 0;
            }

            var closestToZero = numbers
                .OrderBy(Math.Abs)
                .ThenByDescending(x => x)
                .First();

            return closestToZero;
        }
    }
}
