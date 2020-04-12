using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.Pages
{
    class HomePage
    {
        public void ValidateLogin(IWebDriver driver)
        {
           // Assert.That(driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a")).Text, Is.EqualTo("Hello hari!"));
           //validate if the user logged in
            if (driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a")).Text == "Hello hari!")
            {
                Console.WriteLine("Logged in succesfully,Test Passed");
                Assert.Pass();
            }
            else
            {
                Console.WriteLine("Login failed,Test failed");
                    Assert.Fail();
            }
        }
    }
}
