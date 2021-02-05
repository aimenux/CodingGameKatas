using CodingGameKatas;
using FluentAssertions;
using Xunit;

namespace CodingGameKatasTests
{
    public class CalculateTotalPriceKataTests
    {
        [Theory]
        [InlineData(8, 0, 4, 1, 3)]
        [InlineData(9, 50, 2, 3, 6, 1)]
        [InlineData(13, 50, 5, 4, 7, 1)]
        [InlineData(17, 80, 5, 4, 10, 6)]
        [InlineData(20, 100, 4, 10, 30, 6)]
        public void Given_An_Prices_And_Discount_Should_Compute_TotalPrice(int expected, int discount, params int[] prices)
        {
            // arrange
            // act
            var totalPrice = CalculateTotalPriceKata.CalculateTotalPrice(prices, discount);

            // assert
            totalPrice.Should().Be(expected);
        }
    }
}