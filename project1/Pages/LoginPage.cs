using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.Pages
{
    class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            //enter url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //maximize the browser
            driver.Manage().Window.Maximize();

            //find username textbox and enter username
            driver.FindElement(By.Id("UserName")).SendKeys("hari");

            //find password textbox and enter password
            driver.FindElement(By.Id("Password")).SendKeys("123123");

            //find login button and click login
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();
        }
    }
}

    

