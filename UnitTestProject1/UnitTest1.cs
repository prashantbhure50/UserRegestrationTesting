using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegestrationRegex;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Pattern pattern = new Pattern();
        [TestMethod]
        public void TestMethod1()
        {
           bool res= pattern.firstNameCheck("Prashant");
            Assert.IsTrue(res);
           
        }
        [TestMethod]
        public void TestMethod2()
        {
            bool res=pattern.lastNameCheck("Bhure");
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void TestMethod3()
        {
          bool res =   pattern.EmailCheck("abc.xyz@bl.co.in");
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void TestMethod4()
        {
           bool res =  pattern.MobileCheck("91 7000593588");
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void TestMethod5()
        {
            bool res = pattern.PasswordEmailCheck("@bcdEfghi1");
            Assert.IsTrue(res);
        }
        
    }
}