using BenchmarkDotNet.Attributes;
using SortingBenchmark.Extensions;

namespace SortingBenchmark;

public class SortingBenchmark
{
    private const int TestArraySize = 10_000;
    private readonly List<int> _testArray = Enumerable.Range(0, TestArraySize).ToList();

    [IterationSetup]
    public void PrepareTestData() => _testArray.PopulateWithRandomValues();

    [Benchmark]
    public void NativeSort() => _testArray.Sort();

    [Benchmark]
    public void BubbleSort() => _testArray.BubbleSort();

    [Benchmark]
    public void SelectionSort() => _testArray.SelectionSort();

    [Benchmark]
    public void QuickSortExternal() => _testArray.QuickSortExternal();
}