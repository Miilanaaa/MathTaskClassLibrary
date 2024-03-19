using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;
using System;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            int a = 3; int b = 5;
            int expected = 17;

            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
