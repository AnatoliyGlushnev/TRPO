using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcLib;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class MyCalcLibTests
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            int x = 10, y = 20;
            int expcted = 30;

            MyCalcLib c = new MyCalcLib();
            int actual = c.Sum(x, y);

            Assert.AreEqual(expcted, actual);
        }
    }
}
