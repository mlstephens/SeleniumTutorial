using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SeleniumTutorial
{
    public class SeleniumSetMethods
    {
        //set value of a text control
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //click into a button, Checkbox, option etc
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
        }

        //selecting a drop down control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
