using BenchmarkDotNet.Attributes;
using ConsoleApp7.Extensions;

namespace ConsoleApp7;

public class SortingBenchmark
{
    private const int TestArraySize = 10_000;
    private static List<int> _testArray;

    [IterationSetup]
    public void PrepareTestData()
    {
        var random = new Random();

        _testArray = 
            Enumerable
                .Range(0, TestArraySize)
                .Select(_ => random.Next())
                .ToList();
    }

    [Benchmark]
    public void NativeSort() => _testArray.Sort();

    [Benchmark]
    public void BubbleSort() => _testArray.BubbleSort();

    [Benchmark]
    public void SelectionSort() => _testArray.SelectionSort();
}