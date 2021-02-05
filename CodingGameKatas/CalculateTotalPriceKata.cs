using System;
using System.Linq;

namespace CodingGameKatas
{
    public static class CalculateTotalPriceKata
    {
        public static int CalculateTotalPrice(int[] prices, int discount)
        {
            var maxPrice = prices.Max();
            var discountPrice = (decimal) maxPrice * discount / 100;
            var totalPrice = prices.Sum() - discountPrice;
            var roundedTotalPrice = (int) Math.Floor(totalPrice);
            return roundedTotalPrice;
        }
    }
}