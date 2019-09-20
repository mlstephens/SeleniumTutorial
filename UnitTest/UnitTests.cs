using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTutorial;

namespace UnitTest
{
    [TestClass]
    public class UnitTests
    {
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            //navigate to default site
            //webDriver.Navigate().GoToUrl("http://www.google.com");
        }

        [Test]
        public void ExecuteTest_BrowserTextSearch()
        {
            //navigate to google page
            webDriver.Navigate().GoToUrl("http://www.google.com");

            Console.WriteLine("Opened URL");

            //find the Element - search box
            IWebElement element = webDriver.FindElement(By.Name("q"));

            //set up search text
            element.SendKeys("executeautomation");

            Thread.Sleep(1000);

            //find search button and click
            element = webDriver.FindElement(By.Name("btnK"));
            element.Click();

            Console.WriteLine("Executed Search");
        }

        [Test]
        public void ExecuteTest_CustomControlMethods()
        {
            //navigate to demo site page
            webDriver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");

            Console.WriteLine("Opened Demo Site URL");

            //title
            SeleniumSetMethods.SelectDropDown(webDriver, "TitleId", "Mr.", "Id");

            //initial
            SeleniumSetMethods.EnterText(webDriver, "Initial", "M", "Name");

            //first name
            SeleniumSetMethods.EnterText(webDriver, "FirstName", "Michael", "Name");

            //middle name
            SeleniumSetMethods.EnterText(webDriver, "MiddleName", "Lee", "Name");

            //gender
            SeleniumSetMethods.Click(webDriver, "Female", "Name");

            //languages
            SeleniumSetMethods.Click(webDriver, "Hindi", "Name");
            
            //save button
            SeleniumSetMethods.Click(webDriver, "Save", "Name");

            Console.WriteLine("Executed Save Values");

            Thread.Sleep(1000);

            Console.WriteLine("Get New Values");

            //title
            Console.WriteLine("Title: " + SeleniumGetMethods.GetTextFromDDL(webDriver, "TitleId", "Name"));

            //initial
            Console.WriteLine("Initial: " + SeleniumGetMethods.GetText(webDriver, "Initial", "Name"));

            //first name
            Console.WriteLine("First Name: " + SeleniumGetMethods.GetText(webDriver, "FirstName", "Name"));

            //middle name
            Console.WriteLine("Middle Name: " + SeleniumGetMethods.GetText(webDriver, "MiddleName", "Name"));

            Console.WriteLine("Executed Get New Values");
        }

        [TearDown]
        public void CleanUp()
        {
            //driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
