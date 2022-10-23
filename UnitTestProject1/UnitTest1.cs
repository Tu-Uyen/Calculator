using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private object txtKetqua;

        [TestMethod]
        public void TestAddOperator()
        {
           //ab= 10,5/15
            Calculation cal = new Calculation(10, 5);
            Assert.AreEqual(10, cal.Execute("+")); //15
        }
    }
}
