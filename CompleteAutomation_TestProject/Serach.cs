using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;

namespace CompleteAutomation_TestProject
{
    [TestClass]
    public class TestClass
    {
        IWebDriver _driver;
        [TestInitialize]
        public void TestSetUp()
        {
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl("http://www.google.co.in");
            _driver.Manage().Window.Maximize();
        }
        [TestMethod]
        public void Search() 
        {
            _driver.FindElement(By.Name("q")).Clear();
            _driver.FindElement(By.Name("q")).SendKeys("Selenium");
            _driver.FindElement(By.Name("btnG")).Click();
            string Title = _driver.Title;
            Assert.AreEqual("Selenium - Google Search", Title, "Actual value is same Expected");
        }
        [TestCleanup]
        public void TestTeardown()
        {
            _driver.Quit();
        }
 
    }
}