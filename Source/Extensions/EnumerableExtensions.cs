namespace SortingBenchmark.Extensions;

public static class EnumerableExtensions
{
    public static List<T> ToList<T>(this IEnumerable<T> items, int capacity)
    {
        List<T> list = new(capacity);
        list.AddRange(items);

        return list;
    }
}