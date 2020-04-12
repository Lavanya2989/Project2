using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project1.Pages
{
        class CustomerPage
    {
        public void NavigateToCustomerPage(IWebDriver driver)
        {
            //Fiind Element administration
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            //Drop down and click on Customer
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a")).Click();
        }
        public void CreateCustomer(IWebDriver driver)
        {
            //Click create new
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            Thread.Sleep(2000);
            //enter name
            driver.FindElement(By.XPath("//*[@id='Name']")).SendKeys("abcd");
            //edit contact
               //enter last name
               //enter address and details
            driver.FindElement(By.XPath("//*[@id='EditContactButton']")).Click();
            //enter name
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='FirstName']")).SendKeys("abcd");
            driver.FindElement(By.XPath("//*[@id='LastName']")).SendKeys("efg");
            //enter phone
            driver.FindElement(By.XPath("//*[@id='Phone']")).SendKeys("12345");
            //enteremail
            driver.FindElement(By.XPath("//*[@id='email']")).SendKeys("abc@gmail.com");
            //enter address
            driver.FindElement(By.XPath("//*[@id='Street']")).SendKeys("njk");
            //enter city
            driver.FindElement(By.XPath("//*[@id='City']")).SendKeys("akl");
            //enter save
            driver.FindElement(By.XPath("//*[@id='submitButton']")).Click();
            //enter tick box as same as above
            driver.FindElement(By.XPath("//*[@id='IsSameContact']")).Click();
            //enter gst
            driver.FindElement(By.XPath("//*[@id='GST']")).SendKeys("2");
            //enter save
            driver.FindElement(By.XPath("//*[@id='submitButton']")).Click();
             }
        public void EditCustomer(IWebDriver driver)
        {
            //Navigate to lastpage
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[4]/a[4]")).Click();
            //enter edit
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[1]/td[4]/a[1]")).Click();
            //enter name
            driver.FindElement(By.XPath("//*[@id='Name']")).Clear();
            driver.FindElement(By.XPath("//*[@id='Name']")).SendKeys("def");
            //enter edit contact
            driver.FindElement(By.XPath("//*[@id='EditContactButton']")).Click();
            //enter firstname
            driver.FindElement(By.XPath("//*[@id='FirstName']")).Clear();
            driver.FindElement(By.XPath("//*[@id='FirstName']")).SendKeys("def");
            //enter lastname
            driver.FindElement(By.XPath("//*[@id='LastName']")).Clear();
            driver.FindElement(By.XPath("//*[@id='LastName']")).SendKeys("hij");
            //enter phone num
            driver.FindElement(By.XPath("//*[@id='Phone']")).Clear();
            driver.FindElement(By.XPath("//*[@id='Phone']")).SendKeys("45678");
            //enter street
            driver.FindElement(By.XPath("//*[@id='Street']")).Clear();
            driver.FindElement(By.XPath("//*[@id='Street']")).SendKeys("34");
            //enter city
            driver.FindElement(By.XPath("//*[@id='City']")).Clear();
            driver.FindElement(By.XPath("//*[@id='City']")).SendKeys("wlg");
            //enter save
            driver.FindElement(By.XPath("//*[@id='submitButton']")).Click();
            // enter tick box as same as above
            driver.FindElement(By.XPath("//*[@id='IsSameContact']")).Click();
            //enter gst
            driver.FindElement(By.XPath("//*[@id='GST']")).Clear();
            driver.FindElement(By.XPath("//*[@id='GST']")).SendKeys("3");
            //enter save
            driver.FindElement(By.XPath("//*[@id='submitButton']")).Click();
        }
        public void DeleteCustomer(IWebDriver driver)
        {
            //Navigate to lastPage
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[4]/a[4]")).Click();
            Thread.Sleep(1000);
            //delete action
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[5]/td[4]/a[2]")).Click();
        }

    }
}
