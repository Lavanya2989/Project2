using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using project1.Pages;

namespace Helpers
{
    class CommonDriver
    {
        //initialize driver
        public IWebDriver driver { set; get; }
        [OneTimeSetUp]
        public void TestSetUp()
        {
            //define driver
            driver = new ChromeDriver();

            //login page objectD:\project1\project1\Program.cs
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);
        }
        [OneTimeTearDown]
        public void TestTearDown()
        {
            driver.Quit();
        }

    }
}
