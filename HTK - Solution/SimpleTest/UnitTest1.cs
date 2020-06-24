using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using API;

namespace SimpleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestApiKey()
        {
            Control _control = new Control();
            string test = _control.ApiKey();
            Assert.AreEqual(test, "291c93497e96ae5f8e2b01e60a34a1c1");
        }
    }
}
