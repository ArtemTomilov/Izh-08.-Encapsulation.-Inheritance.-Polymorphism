using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Izh_08.Encapsulation;


namespace test_task_8._1
{
    [TestClass]
    public class BubbleSortTest
    {
        [TestMethod]
        public void DescendingSumLinesTest()
        {
            int[,] arr = new int[,]
            {
                {0,1,2,4,188 },
                {22,69,51,7,1 },
                {4,44,54,31,2 },
                {21,99,3,5,33 }

            };

            int[,] result = BubbleSort.DescendingSumLines(arr);

            int[,] expected = new int[,]
            {
                {4,44,54,31,2 },
                {22,69,51,7,1 },
                {21,99,3,5,33 },
                {0,1,2,4,188 }
            };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AscendingSumLinesTest()
        {
            int[,] arr = new int[,]
            {
                {0,1,2,4,188 },
                {22,69,51,7,1 },
                {4,44,54,31,2 },
                {21,99,3,5,33 }

            };

            int[,] result = BubbleSort.AscendingSumLines(arr);

            int[,] expected = new int[,]
            {

                {0,1,2,4,188 },
                {21,99,3,5,33 },
                {22,69,51,7,1 },
                {4,44,54,31,2 }
            };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AscendingMaxNumberTest()
        {
            int[,] arr = new int[,]
            {
                {0,1,2,4,188 },
                {22,69,51,7,1 },
                {4,44,54,31,2 },
                {21,99,3,5,33 }

            };

            int[,] result = BubbleSort.AscendingMaxNumber(arr);

            int[,] expected = new int[,]
            {

                {0,1,2,4,188 },
                {21,99,3,5,33 },
                {22,69,51,7,1 },
                {4,44,54,31,2 }
            };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DescendingMaxNumberTest()
        {
            int[,] arr = new int[,]
            {
                {0,1,2,4,188 },
                {22,69,51,7,1 },
                {4,44,54,31,2 },
                {21,99,3,5,33 }

            };

            int[,] result = BubbleSort.DescendingMaxNumber(arr);

            int[,] expected = new int[,]
            {
                {4,44,54,31,2 },
                {22,69,51,7,1 },
                {21,99,3,5,33 },
                {0,1,2,4,188 }
            };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AscendingMinNumberTest()
        {
            int[,] arr = new int[,]
            {
                {0,1,2,4,188 },
                {22,69,51,7,1 },
                {4,44,54,31,2 },
                {21,99,3,5,33 }

            };

            int[,] result = BubbleSort.AscendingMinNumber(arr);

            int[,] expected = new int[,]
            {

                {0,1,2,4,188 },
                {22,69,51,7,1 },
                 {4,44,54,31,2 },
                {21,99,3,5,33 },

            };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DescendingMinNumberTest()
        {
            int[,] arr = new int[,]
            {
                {0,1,2,4,188 },
                {22,69,51,7,1 },
                {4,44,54,31,2 },
                {21,99,3,5,33 }

            };

            int[,] result = BubbleSort.DescendingMinNumber(arr);

            int[,] expected = new int[,]
            {
                {21,99,3,5,33 },
                {4,44,54,31,2 },
                 {22,69,51,7,1 },
                {0,1,2,4,188 }
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
