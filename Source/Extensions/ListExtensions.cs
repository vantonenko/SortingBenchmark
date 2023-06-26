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
        throw new NotImplementedException();
    }
}