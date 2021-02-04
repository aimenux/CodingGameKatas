using System;
using CodingGameKatas;
using FluentAssertions;
using Xunit;

namespace CodingGameKatasTests
{
    public class ClosestToZeroKataTests
    {
        [Fact]
        public void Given_Null_Array_Should_Compute_Zero_As_Closest_To_Zero()
        {
            // arrange
            const int[] numbers = null;

            // act
            var closest = ClosestToZeroKata.ClosestToZero(numbers);

            // assert
            closest.Should().Be(0);
        }

        [Fact]
        public void Given_Empty_Array_Should_Compute_Zero_As_Closest_To_Zero()
        {
            // arrange
            var numbers = Array.Empty<int>();

            // act
            var closest = ClosestToZeroKata.ClosestToZero(numbers);

            // assert
            closest.Should().Be(0);
        }

        [Theory]
        [InlineData(3, 3)]
        [InlineData(-3, -3)]
        [InlineData(5, 2, 1, 1)]
        [InlineData(5, 2, -2, 2)]
        [InlineData(13, 0, -6, 0)]
        [InlineData(2, -1, -2, -3, -1)]
        public void Given_Not_Empty_Array_Should_Compute_Closest_To_Zero(params int[] parameters)
        {
            // arrange
            var numbers = parameters[..^1];
            var expected = parameters[^1];

            // act
            var closest = ClosestToZeroKata.ClosestToZero(numbers);

            // assert
            closest.Should().Be(expected);
        }
    }
}
