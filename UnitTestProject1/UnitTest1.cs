using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void TestMethod1()
        {
            int test = 1;
            Assert.IsTrue(test == 1);
        }
    }
}
