using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace HomeCareServiceTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //string url = "http://localhost:49198/Clients/Create";
            string url = "http://localhost:50277";
            //string url = "http://localhost:49198";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //driver.FindElement(By.LinkText("Client")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //driver.FindElement(By.LinkText("Create New")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //driver.FindElement(By.Id("Name")).SendKeys("Marge Simpson");
            //driver.FindElement(By.Id("Address")).SendKeys("Springfield");
            //driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
        }
    }
}
