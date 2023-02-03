using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace HomeCareServiceTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1_AddService()
        {
            string url = "http://localhost:50277";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Service")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create a new Service")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Name")).SendKeys("Home");
            driver.FindElement(By.Id("Price")).SendKeys("1000");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }

        public void Test1_AddService2()
        {
            string url = "http://localhost:50277";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Service")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create a new Service")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Name")).SendKeys("Work");
            driver.FindElement(By.Id("Price")).SendKeys("1000");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }

        [TestMethod]
        public void Test2_AddEmployee()
        {
            string url = "http://localhost:50277";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Employee")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Add a New Employee")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Name")).SendKeys("Worker");
            driver.FindElement(By.Id("Address")).SendKeys("BCIT");
            driver.FindElement(By.Id("Salary")).SendKeys("10000");
            SelectElement dropDown = new SelectElement(driver.FindElement(By.XPath("//*[@id='services_ID']")));
            dropDown.SelectByText("Home");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }

        [TestMethod]
        public void Test2_AddEmployee2()
        {
            string url = "http://localhost:50277";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Employee")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Add a New Employee")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Name")).SendKeys("Buster");
            driver.FindElement(By.Id("Address")).SendKeys("BCIT");
            driver.FindElement(By.Id("Salary")).SendKeys("10000");
            SelectElement dropDown = new SelectElement(driver.FindElement(By.XPath("//*[@id='services_ID']")));
            dropDown.SelectByText("Home");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }

        [TestMethod]
        public void Test3_AddCustomer()
        {
            string url = "http://localhost:50277";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Customer")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Add a new Customer")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Name")).SendKeys("Client");
            driver.FindElement(By.Id("Address")).SendKeys("Vancouver");
            driver.FindElement(By.Id("Home")).Click();
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }

        [TestMethod]
        public void Test3_AddCustomer2()
        {
            string url = "http://localhost:50277";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Customer")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Add a new Customer")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Name")).SendKeys("John");
            driver.FindElement(By.Id("Address")).SendKeys("Vancouver");
            driver.FindElement(By.Id("Home")).Click();
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }

        [TestMethod]
        public void Test4_EditService() {
            string url = "http://localhost:50277";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Service")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Edit")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//input[@id='Name']")).Clear();
            driver.FindElement(By.XPath("//input[@id='Name']")).SendKeys("Construction");
            driver.FindElement(By.XPath("//input[@id='Price']")).Clear();
            driver.FindElement(By.XPath("//input[@id='Price']")).SendKeys("2000");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }

        [TestMethod]
        public void Test5_EditEmployee()
        {
            string url = "http://localhost:50277";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Employee")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Edit")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//input[@id='Name']")).Clear();
            driver.FindElement(By.XPath("//input[@id='Name']")).SendKeys("Bob");
            driver.FindElement(By.XPath("//input[@id='Address']")).Clear();
            driver.FindElement(By.XPath("//input[@id='Address']")).SendKeys("Richmond");
            driver.FindElement(By.XPath("//input[@id='Salary']")).Clear();
            driver.FindElement(By.XPath("//input[@id='Salary']")).SendKeys("2000");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }

        [TestMethod]
        public void Test6_EditCustomer()
        {
            string url = "http://localhost:50277";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Customer")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Edit")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//input[@id='Name']")).Clear();
            driver.FindElement(By.XPath("//input[@id='Name']")).SendKeys("Terry");
            driver.FindElement(By.XPath("//input[@id='Address']")).Clear();
            driver.FindElement(By.XPath("//input[@id='Address']")).SendKeys("Burnaby");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }

        [TestMethod]
        public void Test7_DeleteEmployee()
        {
            string url = "http://localhost:50277";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Employee")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Delete")).Click();
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }

        [TestMethod]
        public void Test8_DeleteService()
        {
            string url = "http://localhost:50277";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Service")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Delete")).Click();
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }

        [TestMethod]
        public void Test9_DeleteCustomer()
        {
            string url = "http://localhost:50277";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Customer")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Delete")).Click();
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }
    }
}
