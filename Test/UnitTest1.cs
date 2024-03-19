using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x1 = 1;
            double y1 = 2;
            double R1 = 3;

            int expected1 = 1;

            CheckOnEntryPointInCircle c1 = new CheckOnEntryPointInCircle(R1);
            int actual1 = c1.CheckOnEntry(x1, y1);

            Assert.AreEqual(expected1, actual1);

        }
        [TestMethod]
        public void TestMethod2()
        {

            double x2 = 5;
            double y2 = 2;
            double R2 = 3;

            int expected2 = 0;

            CheckOnEntryPointInCircle c2 = new CheckOnEntryPointInCircle(R2);
            int actual2 = c2.CheckOnEntry(x2, y2);

            Assert.AreEqual(expected2, actual2);
        }

    }
}
