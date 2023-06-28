namespace ConsoleApp7.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<T> Concat<T>(this IEnumerable<T> items, T item) => items.Concat(new[] { item });

    public static IEnumerable<int> ExceptIndex(this IList<int> items, int indexOfItemToSkip) =>
        Enumerable
            .Range(0, items.Count)
            .Where(i => i != indexOfItemToSkip)
            .Select(i => items[i]);

    public static List<T> ToList<T>(this IEnumerable<T> items, int capacity)
    {
        List<T> list = new(capacity);
        list.AddRange(items);

        return list;
    }
}