using System.Runtime.CompilerServices;

namespace ConsoleApp7.Extensions;

public static class ListExtensions
{
    public static void BubbleSort(this IList<int> items)
    {
        int count = items.Count;

        do
        {
            bool shouldMakeAnotherRound = false;
            for (int i = 0; i < count - 1; i++)
            {
                if (items[i] > items[i + 1])
                {
                    (items[i], items[i + 1]) = (items[i + 1], items[i]);
                    shouldMakeAnotherRound = true;
                }
            }

            if (!shouldMakeAnotherRound)
            {
                break;
            }
        } while (true);
    }

    public static void SelectionSort(this IList<int> items)
    {
        int count = items.Count;

        for (int i = 0; i < count - 1; i++)
        {
            var iMin = items.IndexOfMin(i, count);

            if (i != iMin)
            {
                (items[i], items[iMin]) = (items[iMin], items[i]);
            }
        }
    }

    public static void PopulateWithRandomValues(this IList<int> items)
    {
        var random = new Random();
        foreach (int i in Enumerable.Range(0, items.Count))
        {
            items[i] = random.Next();
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IndexOfMin(this IList<int> items, int start, int count)
    {
        int min = int.MaxValue;
        int iMin = start;

        for (int i = start; i < count; i++)
        {
            if (items[i] < min)
            {
                min = items[i];
                iMin = i;
            }
        }

        return iMin;
    }
}