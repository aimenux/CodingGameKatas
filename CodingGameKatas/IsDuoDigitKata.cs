using System;
using System.Linq;

namespace CodingGameKatas
{
    public static class IsDuoDigitKata
    {
        public static int IsDuoDigit(int number)
        {
            var positiveNumber = Math.Abs(number).ToString();
            var numbers = positiveNumber.ToCharArray();
            return numbers.Distinct().Count() <= 2 ? 1 : 0;
        }
    }
}
