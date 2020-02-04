using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Izh_08.Encapsulation;


namespace test_task_8._1
{
    [TestClass]
    public class DescendingSumLinesTest
    {
        [TestMethod]
        public void ThisSortTest()
        {
            int[,] arr = new int[,]
            {
                {0,1,2,4,188 },
                {22,69,51,7,1 },
                {4,44,54,31,2 },
                {21,99,3,5,33 }
            };

            DescendingSumLines DesSumLin = new DescendingSumLines();
            DesSumLin.ArrayNumber = arr;

            DesSumLin.ThisSort();
            int[,] result = DesSumLin.ResultSort;

            int[,] expected = new int[,]
            {
                {4,44,54,31,2 },
                {22,69,51,7,1 },
                {21,99,3,5,33 },
                {0,1,2,4,188 }
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class AscendingSumLinesTest
    {
        [TestMethod]
        public void ThisSortTest()
        {
            int[,] arr = new int[,]
            {
                {0,1,2,4,188 },
                {22,69,51,7,1 },
                {4,44,54,31,2 },
                {21,99,3,5,33 }
            };

            AscendingSumLines AscSumLin = new AscendingSumLines();
            AscSumLin.ArrayNumber = arr;

            AscSumLin.ThisSort();
            int[,] result = AscSumLin.ResultSort;

            int[,] expected = new int[,]
            {
                {0,1,2,4,188 },
                {21,99,3,5,33 },
                {22,69,51,7,1 },
                {4,44,54,31,2 }
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class DescendingMaxNumberTest
    {
        [TestMethod]
        public void ThisSortTest()
        {
            int[,] arr = new int[,]
            {
                {0,1,2,4,188 },
                {22,69,51,7,1 },
                {4,44,54,31,2 },
                {21,99,3,5,33 }
            };

            DescendingMaxNumber DesMaxNum = new DescendingMaxNumber();
           DesMaxNum.ArrayNumber = arr;

            DesMaxNum.ThisSort();
            int[,] result = DesMaxNum.ResultSort;

            int[,] expected = new int[,]
            {
                {4,44,54,31,2 },
                {22,69,51,7,1 },
                {21,99,3,5,33 },
                {0,1,2,4,188 }
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class AscendingMinNumberTest
    {
        [TestMethod]
        public void ThisSortTest()
        {
            int[,] arr = new int[,]
            {
                {0,1,2,4,188 },
                {22,69,51,7,1 },
                {4,44,54,31,2 },
                {21,99,3,5,33 }
            };

            AscendingMinNumber AscMinNum = new AscendingMinNumber();
            AscMinNum.ArrayNumber = arr;

            AscMinNum.ThisSort();
            int[,] result = AscMinNum.ResultSort;

            int[,] expected = new int[,]
            {
                {0,1,2,4,188 },
                {22,69,51,7,1 },
                {4,44,54,31,2 },
                {21,99,3,5,33 },
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class DescendingMinNumberTest
    {
        [TestMethod]
        public void ThisSortTest()
        {
            int[,] arr = new int[,]
            {
                {0,1,2,4,188 },
                {22,69,51,7,1 },
                {4,44,54,31,2 },
                {21,99,3,5,33 }
            };

            DescendingMinNumber DesMinNum = new DescendingMinNumber();
            DesMinNum.ArrayNumber = arr;

            DesMinNum.ThisSort();
            int[,] result = DesMinNum.ResultSort;

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
      
