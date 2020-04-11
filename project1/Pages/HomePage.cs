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
        public void NavigateToTMPage(IWebDriver driver)
        {
                   //Find element administration
                driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a")).Click();

                //Drop down and click on Time and Material
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
         }
        public void NavigateToCustomerPage(IWebDriver driver)
        {
                            //Fiind Element administration
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
                //Drop down and click on Customer
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a")).Click();
        }

    }
}
