using BenchmarkDotNet.Attributes;
using ConsoleApp7.Extensions;

namespace ConsoleApp7;

public class SortingBenchmark
{
    private const int TestArraySize = 10_000;
    private readonly List<int> TestArray = 
        Enumerable.Range(0, TestArraySize).ToList();

    [IterationSetup]
    public void PrepareTestData() => TestArray.PopulateWithRandomValues();

    [Benchmark]
    public void NativeSort() => TestArray.Sort();
    
    [Benchmark]
    public void BubbleSort() => TestArray.BubbleSort();

    [Benchmark]
    public void SelectionSort() => TestArray.SelectionSort();
    
    [Benchmark]
    public void QuickSortExternal() => TestArray.QuickSortExternal();
}