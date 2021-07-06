using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace June2021.Pages
{
    class LoginPage
    {
        // functions that allows users to login to TP portal
        public void LoginActions(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();

            // launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // identify username textbox and enter valid username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            // identify password textbox and enter valid password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            // indentify login action button and click
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
        }
    }
}
