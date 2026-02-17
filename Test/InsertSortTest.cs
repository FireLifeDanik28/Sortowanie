using Sortowanie;
using System;

namespace Test
{
    [TestClass]
    public sealed class InsertSortTestDouble
    {
        [TestMethod]
        public void UnsortedArr()
        {
            double[] tablica = { 1, 67, 3, 2, 7.3, 9, 0 };
            double[] result = InsertSort.Sort(tablica);

            CollectionAssert.AreEqual(result, new double[] { 0, 1, 2, 3, 7.3, 9, 67 });
        }

        [TestMethod]
        public void SortedArr()
        {
            double[] tablica = { 0, 1, 2, 3, 7.3, 9, 67 };
            double[] result = InsertSort.Sort(tablica);

            CollectionAssert.AreEqual(result, new double[] { 0, 1, 2, 3, 7.3, 9, 67 });
        }

        [TestMethod]
        public void DescSortedArr()
        {
            double[] tablica = { 67, 9, 7, 3, 2.137, 1, 0 };
            double[] result = InsertSort.Sort(tablica);

            CollectionAssert.AreEqual(result, new double[] { 0, 1, 2.137, 3, 7, 9, 67 });
        }

        [TestMethod]
        public void EmptyArr()
        {
            double[] tablica = new double[0];
            double[] result = InsertSort.Sort(tablica);

            CollectionAssert.AreEqual(result, new double[0]);
        }

        [TestMethod]
        public void SingleElementArr()
        {
            double[] tablica = { 67 };
            double[] result = InsertSort.Sort(tablica);

            CollectionAssert.AreEqual(result, new double[] { 67 });
        }

        [TestMethod]
        public void DuplicatedArr()
        {
            double[] tablica = { 67, 1, 8, 3, 67, 9, 67 };
            double[] result = InsertSort.Sort(tablica);

            CollectionAssert.AreEqual(result, new double[] { 1, 3, 8, 9, 67, 67, 67 });
        }

        [TestMethod]
        public void IdenticalArr()
        {
            double[] tablica = { 67, 67, 67, 67, 67, 67, 67 };
            double[] result = InsertSort.Sort(tablica);

            CollectionAssert.AreEqual(result, new double[] { 67, 67, 67, 67, 67, 67, 67 });
        }

        [TestMethod]
        public void NegativeArr()
        {
            double[] tablica = { -67, 2, 67, -228, 0, -7, 6 };
            double[] result = InsertSort.Sort(tablica);

            CollectionAssert.AreEqual(result, new double[] { -228, -67, -7, 0, 2, 6, 67 });
        }

        [TestMethod]
        public void ShitTonArr()
        {
            Random random = new Random();
            double[] tablica = Enumerable.Range(0, 1000)
                                         .Select(x => random.NextDouble() * 100 + 1)
                                         .ToArray();

            double[] result = InsertSort.Sort(tablica);
            double[] sorted2 = tablica.ToArray();
            Array.Sort(sorted2);

            CollectionAssert.AreEqual(result, sorted2);
        }
    }

    [TestClass]
    public sealed class InsertSortTestInt
    {
        [TestMethod]
        public void UnsortedArr()
        {
            int[] tablica = { 1, 67, 3, 2, 7, 9, 0 };
            int[] result = InsertSort.Sort(tablica);

            CollectionAssert.AreEqual(result, new int[] { 0, 1, 2, 3, 7, 9, 67 });
        }

        [TestMethod]
        public void SortedArr()
        {
            int[] tablica = { 0, 1, 2, 3, 7, 9, 67 };
            int[] result = InsertSort.Sort(tablica);

            CollectionAssert.AreEqual(result, new int[] { 0, 1, 2, 3, 7, 9, 67 });
        }

        [TestMethod]
        public void DescSortedArr()
        {
            int[] tablica = { 67, 9, 7, 3, 2, 1, 0 };
            int[] result = InsertSort.Sort(tablica);

            CollectionAssert.AreEqual(result, new int[] { 0, 1, 2, 3, 7, 9, 67 });
        }

        [TestMethod]
        public void EmptyArr()
        {
            int[] tablica = new int[0];
            int[] result = InsertSort.Sort(tablica);

            CollectionAssert.AreEqual(result, new int[0]);
        }

        [TestMethod]
        public void SingleElementArr()
        {
            int[] tablica = {67};
            int[] result = InsertSort.Sort(tablica);

            CollectionAssert.AreEqual(result, new int[] {67});
        }

        [TestMethod]
        public void DuplicatedArr()
        {
            int[] tablica = { 67, 1, 8, 3, 67, 9, 67 };
            int[] result = InsertSort.Sort(tablica);

            CollectionAssert.AreEqual(result, new int[] { 1, 3, 8, 9, 67, 67, 67 });
        }

        [TestMethod]
        public void IdenticalArr()
        {
            int[] tablica = { 67, 67, 67, 67, 67, 67, 67 };
            int[] result = InsertSort.Sort(tablica);

            CollectionAssert.AreEqual(result, new int[] { 67, 67, 67, 67, 67, 67, 67 });
        }

        [TestMethod]
        public void NegativeArr()
        {
            int[] tablica = { -67, 2, 67, -228, 0, -7, 6 };
            int[] result = InsertSort.Sort(tablica);

            CollectionAssert.AreEqual(result, new int[] { -228, -67, -7, 0, 2, 6, 67 });
        }

        [TestMethod]
        public void ShitTonArr()
        {
            Random random = new Random();
            int[] tablica = Enumerable.Range(0, 1000)
                                     .Select(x => random.Next(1, 101))
                                     .ToArray();

            int[] result = InsertSort.Sort(tablica);
            List<int> sorted = tablica.ToList();
            sorted.Sort();
            int[] sorted2 = sorted.ToArray();

            CollectionAssert.AreEqual(result, sorted2);
        }
    }
}
