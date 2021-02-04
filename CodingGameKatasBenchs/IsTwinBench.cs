using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using CodingGameKatas;

namespace CodingGameKatasBenchs
{
    [Config(typeof(BenchConfig))]
    [BenchmarkCategory(nameof(BenchCategory.IsTwin))]
    public class IsTwinBench
    {
        private string _str1;
        private string _str2;

        [Params(100, 1000, 10000)]
        public int Length { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            _str1 = RandomString(random, Length);
            _str2 = RandomString(random, Length);
        }

        [Benchmark]
        public bool Solution()
        {
            return IsTwinKata.IsTwin(_str1, _str2);
        }

        private static string RandomString(Random random, int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}