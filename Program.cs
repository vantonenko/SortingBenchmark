using BenchmarkDotNet.Running;

namespace ConsoleApp7
{
    internal class Program
    {
        private static void Main() => BenchmarkRunner.Run<SortingBenchmark>();
    }
}