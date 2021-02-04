using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using CodingGameKatas;

namespace CodingGameKatasBenchs
{
    [Config(typeof(BenchConfig))]
    [BenchmarkCategory(nameof(BenchCategory.ClosestToZero))]
    public class ClosestToZeroBench
    {
        private int[] _array;

        [Params(100, 1000, 10000)]
        public int Size { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            _array = Enumerable.Range(0, Size)
                .Select(_ => random.Next())
                .ToArray();
        }

        [Benchmark]
        public int Solution()
        {
            return ClosestToZeroKata.ClosestToZero(_array);
        }
    }
}