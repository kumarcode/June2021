using June2021.Pages;
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

            // object for login page
            LoginPage loginObj = new LoginPage();
            loginObj.LoginActions(driver);

            // object for home page
            HomePage homeObj = new HomePage();
            homeObj.GoToTMPage(driver);

            // object for TM page
            TMPage tmObj = new TMPage();
            tmObj.CreateTM(driver);

            // rest of the group
            tmObj.EditTM(driver);
            tmObj.DeleteTM(driver);




        }
    }
}
