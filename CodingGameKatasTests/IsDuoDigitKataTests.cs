using CodingGameKatas;
using FluentAssertions;
using Xunit;

namespace CodingGameKatasTests
{
    public class IsDuoDigitKataTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(102, 0)]
        [InlineData(3030, 1)]
        [InlineData(-4035, 0)]
        [InlineData(699696, 1)]
        [InlineData(7777743, 0)]
        [InlineData(-0808080, 1)]
        public void Given_An_Integer_Should_Compute_IsDuoDigit(int number, int expected)
        {
            // arrange
            // act
            var isDuoDigit = IsDuoDigitKata.IsDuoDigit(number);

            // assert
            isDuoDigit.Should().Be(expected);
        }
    }
}
