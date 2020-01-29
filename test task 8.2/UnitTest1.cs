using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_8._2;

namespace test_task_8._2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Circle C1 = new Circle();

            C1.Width = 5.26;
            C1.Square();
            double expected = 21.73008222561522;
            Assert. (expected, C1.Square());
        }
    }
}
