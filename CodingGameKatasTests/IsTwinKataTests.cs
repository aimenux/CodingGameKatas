using CodingGameKatas;
using FluentAssertions;
using Xunit;

namespace CodingGameKatasTests
{
    public class IsTwinKataTests
    {
        [Theory]
        [InlineData("", "", true)]
        [InlineData("", " ", false)]
        [InlineData("AbC", "Bca", true)]
        [InlineData("Listen", "Silent", true)]
        [InlineData("Silent", "Listen", true)]
        [InlineData("AbcDef", "DefAbc", true)]
        [InlineData("TroTro", "TraTra", false)]
        [InlineData("$#{}#$", "$#{.}#$", false)]
        public void Given_An_Integer_Should_Compute_IsDuoDigit(string str1, string str2, bool expected)
        {
            // arrange
            // act
            var isTwin = IsTwinKata.IsTwin(str1, str2);

            // assert
            isTwin.Should().Be(expected);
        }
    }
}