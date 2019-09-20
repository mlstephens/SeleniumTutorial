using System;
using System.Threading;
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
                UseChrome();
            }
            else
            {
                UseIE();
            }

            void UseChrome()
            {
                IWebDriver webDriver = new ChromeDriver();
                webDriver.Navigate().GoToUrl("http://www.google.com");

                IWebElement element = webDriver.FindElement(By.Name("q"));
                element.SendKeys("executeautomation");

                Thread.Sleep(1000);

                element = webDriver.FindElement(By.Name("btnK"));
                element.Click();

                Console.WriteLine("Executed Chrome Search. Hit Return.");
                Console.ReadLine();

                //webDriver.Close();
            }

            void UseIE()
            {
                IWebDriver webDriver = new InternetExplorerDriver();
                webDriver.Navigate().GoToUrl("http://www.google.com");

                IWebElement element = webDriver.FindElement(By.Name("q"));
                element.SendKeys("executeautomation");

                Thread.Sleep(1000);

                element = webDriver.FindElement(By.Name("btnK"));
                element.Click();

                Console.WriteLine("Executed IE Search. Hit Return.");
                Console.ReadLine();

                //webDriver.Close();
            }

        }
    }
}
