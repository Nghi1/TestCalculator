using _151901403_VuThanhNghi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator c;
        public TestContext TestContext { get; set; }
        [TestInitialize]
        public void SetUp()
        {
          
        }  
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",@".\Data\TestData.csv","TestData#csv",DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            float a,b, expected, actual;
            a = float.Parse(TestContext.DataRow[0].ToString());
            b=float.Parse(TestContext.DataRow[1].ToString());
            expected = float.Parse(TestContext.DataRow[2].ToString());
            c = new Calculator(a, b);
            actual = c.Exectute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData1.csv", "TestData1#csv", DataAccessMethod.Sequential)]
        public void TestMethod2()
        {
            float a, b, expected, actual;
            a = float.Parse(TestContext.DataRow[0].ToString());
            b = float.Parse(TestContext.DataRow[1].ToString());
            expected = float.Parse(TestContext.DataRow[2].ToString());
            c = new Calculator(a, b);
            actual = c.Exectute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData2.csv", "TestData2#csv", DataAccessMethod.Sequential)]
        public void TestMethod3()
        {
            float a, b, expected, actual;
            a = float.Parse(TestContext.DataRow[0].ToString());
            b = float.Parse(TestContext.DataRow[1].ToString());
            expected = float.Parse(TestContext.DataRow[2].ToString());
            c = new Calculator(a, b);
            actual = c.Exectute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData3.csv", "TestData3#csv", DataAccessMethod.Sequential)]
        public void TestMethod4()
        {
            float a, b, expected, actual;
            a = float.Parse(TestContext.DataRow[0].ToString());
            b = float.Parse(TestContext.DataRow[1].ToString());
            expected = float.Parse(TestContext.DataRow[2].ToString());
            c = new Calculator(a, b);
            actual = c.Exectute("/");
            Assert.AreEqual(expected, actual);
        }
    }
}
