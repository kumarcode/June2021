using June2021.Pages;
using June2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace June2021
{
    [TestFixture]
    class Program : CommonDriver
    {


        [SetUp]
        public void LoginSteps()
        {
            // open chrome browser
            driver = new ChromeDriver(@"S:\June2021\June2021\");

            // object for login page
            LoginPage loginObj = new LoginPage();
            loginObj.LoginActions(driver);

            // object for home page
            HomePage homeObj = new HomePage();
            homeObj.GoToTMPage(driver);
        }

        [Test]
        public void CreateTMTest()
        {
            // object for TM page
            TMPage tmObj = new TMPage();
            tmObj.CreateTM(driver);
        }

        [Test]
        public void EditTMTest()
        {
            // object for TM page
            TMPage tmObj = new TMPage();

            // rest of the group
            tmObj.EditTM(driver);
        }

        [Test]
        public void DeleteTMTest()
        {
            // object for TM page
            TMPage tmObj = new TMPage();
            tmObj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {

        }
    }
}
