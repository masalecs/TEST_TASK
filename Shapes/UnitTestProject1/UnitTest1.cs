using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double expected = 6;
            int x = 3;
            int y = 4;
            int z = 5;

            Shape triangle = new Shape();
            double actual = triangle.TrianglePlosh(x,y,z);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2() 
        {
            double expected = 30;
            int x = 5;
            int y = 12;
            int z = 13;
            Shape triangle = new Shape();
            double actual = triangle.TrianglePlosh(x, y, z);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double expected = Math.PI * Math.Pow(3, 2);
            int r = 3;
            Shape circle = new Shape();
            double actual = circle.CirclePlosh(r);
            Assert.AreEqual(expected, actual);
        }
    }
}
