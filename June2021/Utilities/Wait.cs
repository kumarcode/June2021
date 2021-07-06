using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace June2021.Utilities
{
    class Wait
    {
        // re-usable function for wait
        public static void WaitForWebElementToExist(IWebDriver driver, string attributeValue, string attribute, int secondsToWait)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, secondsToWait));

            if (attribute == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(attributeValue)));
            }
            if (attribute == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(attributeValue)));
            }
            if (attribute == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(attributeValue)));
            }

        }
    }
}
