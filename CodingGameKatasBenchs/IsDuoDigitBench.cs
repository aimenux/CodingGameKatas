using System;
using BenchmarkDotNet.Attributes;
using CodingGameKatas;

namespace CodingGameKatasBenchs
{
    [Config(typeof(BenchConfig))]
    [BenchmarkCategory(nameof(BenchCategory.IsDuoDigit))]
    public class IsDuoDigitBench
    {
        private int _number;

        [Params(100, 1000, 10000)]
        public int Size { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            _number = random.Next(Size, 10 * Size);
        }

        [Benchmark]
        public int Solution()
        {
            return IsDuoDigitKata.IsDuoDigit(_number);
        }
    }
}