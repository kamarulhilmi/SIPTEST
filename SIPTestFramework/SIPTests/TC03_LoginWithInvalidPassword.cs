using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace SIPTests
{
    [TestClass]
    public class TC03_LoginWithInvalidPassword : TestBase
    {
        [TestMethod]
        public void RunTest_TC03()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "test");
            Assert.IsTrue(Pages.Loginpage.IsAt(), ".");
            
        }
    }
}
