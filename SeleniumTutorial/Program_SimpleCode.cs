using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.Network;
using OpenQA.Selenium.IE;

namespace SeleniumTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 = Chrome");
            Console.WriteLine("2 = Internet Explorer");
            Console.Write("Please select browser:");
            var sel = Console.ReadLine();

            if (sel == "1")
            {
                TestChrome();
            }
            else
            {
                TestIE();
            }

            void TestChrome()
            {
                IWebDriver driver = new ChromeDriver();

                driver.Navigate().GoToUrl("http://www.google.com");

                IWebElement element1 = driver.FindElement(By.Name("q"));
                IWebElement element2 = driver.FindElement(By.Name("btnK"));

                element1.SendKeys("executeautomation");
                element2.Click();

                driver.Close();

                Console.WriteLine("Executed Chrome Search");
            }

            void TestIE()
            {
                IWebDriver driver = new InternetExplorerDriver();

                driver.Navigate().GoToUrl("http://www.google.com");
               
                IWebElement element1 = driver.FindElement(By.Name("q"));
                IWebElement element2 = driver.FindElement(By.Name("btnK"));
                element1.SendKeys("executeautomation");
                element2.Click();

                driver.Close();

                Console.WriteLine("Executed IE Search");
            }

        }
    }
}
