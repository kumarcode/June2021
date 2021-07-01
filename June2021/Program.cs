using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace June2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // open chrome browser
            IWebDriver driver = new ChromeDriver(@"S:\June2021\June2021\");
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

            // check if user is logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if(helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Loggedin successfully, test passed");
            }
            else
            {
                Console.WriteLine("Log in failed, test failed");
            }

            // navigate to time and material page
            Thread.Sleep(500);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click(); 
            Thread.Sleep(500);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click(); 
            Thread.Sleep(1500);

            // click create new button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            Thread.Sleep(1500);

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

            if(actualCode.Text == "June2021")
            {
                Console.WriteLine("Time record created successfully, test passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

        }
    }
}
