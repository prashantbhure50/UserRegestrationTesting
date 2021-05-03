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
        public void GivenFirstName_WhenCheck_ShouldReturnTrue()
        {
           bool res= pattern.firstNameCheck("Prashant");
            Assert.IsTrue(res);
           
        }
        [TestMethod]
        public void GivenLastName_WhenCheck_ShouldReturnTrue()
        {
            bool res=pattern.lastNameCheck("Bhure");
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void GivenEmail_WhenCheck_ShouldReturnTrue()
        {
          bool res =   pattern.EmailCheck("abc.xyz@bl.co.in");
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void GivenMobileNumber_WhenCheck_ShouldReturnTrue()
        {
           bool res =  pattern.MobileCheck("91 7000593588");
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void GivenEmailPassword_WhenCheck_ShouldReturnTrue()
        {
            bool res = pattern.PasswordEmailCheck("@bcdEfghi1");
            Assert.IsTrue(res);
        }
        
    }
}