using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using CodingGameKatas;

namespace CodingGameKatasBenchs
{
    [Config(typeof(BenchConfig))]
    [BenchmarkCategory(nameof(BenchCategory.CalculateTotalPrice))]
    public class CalculateTotalPriceBench
    {
        private int[] _prices;
        private int _discount;

        [Params(100, 1000, 10000)]
        public int Size { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            const int maxPrice = 100_000;
            var random = new Random(Guid.NewGuid().GetHashCode());
            _prices = Enumerable.Range(0, Size)
                .Select(_ => random.Next(maxPrice))
                .ToArray();
            _discount = random.Next(10, 90);
        }

        [Benchmark]
        public int Solution()
        {
            return CalculateTotalPriceKata.CalculateTotalPrice(_prices, _discount);
        }
    }
}