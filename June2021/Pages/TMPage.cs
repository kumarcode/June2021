using June2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace June2021.Pages
{
    class TMPage
    {
        // test - create new TM
        public void CreateTM(IWebDriver driver)
        {
            // click create new button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            Wait.WaitForWebElementToExist(driver, "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]", "XPath", 5);

            // select time from the dropdown list
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();

            // identify code and input code
            driver.FindElement(By.Id("Code")).SendKeys("June2021");

            // identify description and input description 
            driver.FindElement(By.Id("Description")).SendKeys("June2021");

            // identify price per unit and input 
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            driver.FindElement(By.Id("Price")).SendKeys("12");

            // click save button
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(2500);

            // click go to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(1500);

            // check if the created record is present in the table and has expected values
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            // option - 2
            if (actualCode.Text == "June2021")
            {
                Assert.Pass("Time record created successfully, test passed");
            }
            else
            {
                Assert.Fail("Test Failed");
            }

            // option - 1
            Assert.That(actualCode.Text == "June2021", "actual code and the expected code did not match.");
        }

        // test - edit TM
        public void EditTM(IWebDriver driver)
        {
            // Test case 3 - edit the above record
        }

        // test - delete TM
        public void DeleteTM(IWebDriver driver)
        {
            // Test case 4 - delete the above record


        }
    }
}
