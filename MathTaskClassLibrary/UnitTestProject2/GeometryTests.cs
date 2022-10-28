using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary;

namespace MathTaskClassLibrary
{
    [TestClass]
    public class GeomtetryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            int a = 3;
            int b = 5;
            int expected = 15;

            Geometry g = new Geometry();
            int actual = g.Rectaanglearea(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
