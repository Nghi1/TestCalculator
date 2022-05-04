using _151901403_VuThanhNghi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator c;
        [TestInitialize]
        public void SetUp()
        {
            c = new Calculator(10, 5);
        }
        [TestMethod]
        public void TestMethod1()
        {
            float expected, actual;
            expected = 15;
            actual = c.Exectute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            float expected, actual;
            expected = 5;
            actual = c.Exectute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            float expected, actual;
            expected = 50;
            actual = c.Exectute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            float expected, actual;
            expected = 2;
            actual = c.Exectute("/");
            Assert.AreEqual(expected, actual);
        }
    }
}
