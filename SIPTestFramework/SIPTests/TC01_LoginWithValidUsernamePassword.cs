using System;
using SIPTestFramework;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;


namespace SIPTests
{
    [TestClass]
    public class TC01_LoginWithValidUsernamePassword : TestBase
    {
        [TestMethod]
        public void RunTest_TC01()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.LogOut();

            //var driver = new ChromeDriver(@"C:\Users\REG-LPT-077\Documents\Visual Studio 2015\Projects\SIPTestFramework\SIPTestFramework\Drivers");
            //driver.Navigate().GoToUrl("http://172.17.11.110:1010/Account/Login");
            ////driver.Navigate().GoToUrl("http://172.17.11.83:7882/Account/Login");

            //var username = driver.FindElement(By.Id("input_user_name"));
            //username.SendKeys("admin");

            //var password = driver.FindElement(By.Id("input_password"));
            //password.SendKeys("admin");

            //driver.FindElement(By.Id("btn_login")).Click();

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //var Menu1 =
            //    wait.Until(ExpectedConditions.ElementIsVisible(By.Id("menu1")));
            //Menu1.Click();

            //Actions action = new Actions(driver);
            //var subMenu = driver.FindElement(By.XPath("//a[contains(text(),'User')]"));
            //action.MoveToElement(subMenu).Perform();
            //var x = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),'User')]")));

            //var userMngt = driver.FindElement(By.XPath("//a[contains(text(),'User Management')]"));
            //userMngt.Click();

            //var addUser = driver.FindElement(By.Id("btnAddUser"));
            //addUser.Click();


        }
    }
}
