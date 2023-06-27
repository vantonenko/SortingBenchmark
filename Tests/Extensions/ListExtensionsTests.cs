using ConsoleApp7.Extensions;

namespace ConsoleApp7.Tests.Extensions
{
    public class ListExtensionsTests
    {
        [Test]
        [TestCase(new int[] { })]
        [TestCase(new[] { 1 })]
        [TestCase(new[] { 2, 1, 1 })]
        [TestCase(new[] { 2, 1, 1, 2 })]
        [TestCase(new[] { 3, 2, 1 })]
        public void BubbleSortSuccess(IList<int> input)
        {
            input.BubbleSort();

            Assert.That(input, Is.Ordered);
        }

        [Test]
        [TestCase(new int[] { })]
        [TestCase(new[] { 1 })]
        [TestCase(new[] { 2, 1, 1 })]
        [TestCase(new[] { 2, 1, 1, 2 })]
        [TestCase(new[] { 3, 2, 1 })]
        public void SelectionSortSuccess(IList<int> input)
        {
            input.SelectionSort();

            Assert.That(input, Is.Ordered);
        }

        [Test]
        public void PopulateWithRandomValuesSuccess()
        {
            List<int> orderedList = Enumerable.Range(0, 10).ToList();

            Assert.That(orderedList, Is.Ordered);

            orderedList.PopulateWithRandomValues();

            Assert.That(orderedList, Is.Not.Ordered);
        }
    }
}