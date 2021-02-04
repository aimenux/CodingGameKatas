using BenchmarkDotNet.Running;

namespace CodingGameKatasBenchs
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var benchmarks = new[]
            {
                typeof(IsTwinBench),
                typeof(IsDuoDigitBench),
                typeof(ClosestToZeroBench),
            };

            var switcher = new BenchmarkSwitcher(benchmarks);
            switcher.Run(args);
        }
    }
}
