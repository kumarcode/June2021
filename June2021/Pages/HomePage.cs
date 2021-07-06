using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace June2021.Pages
{
    class HomePage
    {
        // function to navigate to TM page
        public void GoToTMPage(IWebDriver driver)
        {
            // navigate to time and material page
            Thread.Sleep(500);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            Thread.Sleep(1500);
        }
    }
}
