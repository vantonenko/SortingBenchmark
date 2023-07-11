using BenchmarkDotNet.Running;

namespace SortingBenchmark
{
    internal class Program
    {
        private static void Main() => BenchmarkRunner.Run<SortingBenchmark>();
    }
}