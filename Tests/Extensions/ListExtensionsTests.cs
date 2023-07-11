using SortingBenchmark.Extensions;

namespace SortingBenchmark.Tests.Extensions
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
        [TestCase(new int[] { })]
        [TestCase(new[] { 1 })]
        [TestCase(new[] { 2, 1, 1 })]
        [TestCase(new[] { 2, 1, 1, 2 })]
        [TestCase(new[] { 3, 2, 1 })]
        public void QuickSortSuccess(IList<int> input)
        {
            input = input.QuickSortExternal();

            Assert.That(input, Is.Ordered);
        }

        [Test]
        public void PopulateWithRandomValuesSuccess()
        {
            List<int> input = Enumerable.Range(0, 100).ToList();

            Assert.That(input, Is.Ordered);

            input.PopulateWithRandomValues();

            Assert.That(input, Is.Not.Ordered);
        }
    }
}