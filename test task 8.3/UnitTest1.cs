using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_8._3;

namespace test_task_8._3
{
    [TestClass]
    public class PolynomTest
    {
        [TestMethod]
        public void OperatorPlusTest()
        {
            double[] arr1 = { 1.5, 2.5, 3.5, 4.5 };
            double[] arr2 = { 1.5, 2.5 };

            Polynom p1 = new Polynom(arr1);
            Polynom p2 = new Polynom(arr2);
            Polynom p = p1 + p2;

            double[] expected = { 3.0, 5.0, 3.5, 4.5 };

            CollectionAssert.AreEqual(expected, p.Coefficients);
        }

        [TestMethod]
        public void OperatorMinusTest()
        {
            double[] arr1 = { 1.5, 2.5, 3.5, 4.5 };
            double[] arr2 = { 1.5, 2.5 };

            Polynom p1 = new Polynom(arr1);
            Polynom p2 = new Polynom(arr2);
            Polynom p = p1 - p2;

            double[] expected = { 0.0, 0.0, 3.5, 4.5 };

            CollectionAssert.AreEqual(expected, p.Coefficients);
        }

        [TestMethod]
        public void OperatorMultiplicationTest()
        {
            double[] arr1 = { 1.5, 2.5, 3.5, 4.5 };
            double[] arr2 = { 1.5, 2.5 };

            Polynom p1 = new Polynom(arr1);
            Polynom p2 = new Polynom(arr2);
            Polynom p = p1 * p2;

            double[] expected = {2.25, 7.5, 11.5, 15.5, 11.25 };

            CollectionAssert.AreEqual(expected, p.Coefficients);
        }

        [TestMethod]
        public void OperatorDivisionTest()
        {
            double[] arr1 = { -81, 0, 12, 1 };
            double[] arr2 = { 3, 1 };

            Polynom p1 = new Polynom(arr1);
            Polynom p2 = new Polynom(arr2);
            Polynom p = p1 / p2;

            double[] expected = { -27, 9, 1 };

            CollectionAssert.AreEqual(expected, p.Coefficients);
        }

        [TestMethod]
        public void OperatorEqualityTest()
        {
            double[] arr1 = { 1.5, 2.5, 3.5, 4.5 };
            double[] arr2 = { 1.5, 2.5, 3.5, 4.5 };

            Polynom p1 = new Polynom(arr1);
            Polynom p2 = new Polynom(arr2);
            
           CollectionAssert.AreEqual(p1.Coefficients, p2.Coefficients);
        }
    }
}
