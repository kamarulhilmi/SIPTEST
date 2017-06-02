﻿using System;
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
    public class TC08_UserGroupSuccessfullyAdded : TestBase
    {
        [TestMethod]
        public void RunTest_TC08()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.UserGroup();
            Assert.IsTrue(Pages.UserGroup.IsAt(), "The user can't access User Group page.");

            Pages.UserGroup.AddUserGroup();
            Assert.IsTrue(Pages.AddUserGroup.IsAt(), "The user can't access Add User Group page");

            Pages.AddUserGroup.AddGroup("AutomationTest01");
        }
    }
}
