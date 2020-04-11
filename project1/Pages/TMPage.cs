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
    class TMPage
    {
        public void NavigateToTMPage(IWebDriver driver)
        {
            //Find element administration
            driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a")).Click();

            //Drop down and click on Time and Material
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
        }
        public void CreateTM(IWebDriver driver)
        {
                        //Create new function
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            //create new function for Material
            //select material
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']")).Click();
            //Enter code
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("cloth");
            //Enter description
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("testing");
            //Enter price
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("10");
            //click save
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            Thread.Sleep(1000);
            //Navigate to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            //click create new
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            Thread.Sleep(2000);
            //Create Time function
            //select time
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']")).Click();
            //enter code
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("hours");
            //enter description
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("test");
            //enter price
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("20");
            Thread.Sleep(3000);
            //enter save
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            //validate TM create
        }
        public void EditTM(IWebDriver driver)
        {
            //Edit function
            //Goto last page of table
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(1000);
            //Enter edit in the last row
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[4]/td[5]/a[1]")).Click();
            //Enter material
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']")).Click();
            //enter code
            driver.FindElement(By.XPath("//*[@id='Code']")).Clear();
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("wood");
            //enter description
            driver.FindElement(By.XPath("//*[@id='Description']")).Clear();
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("abc");
            //Enter price
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Clear();
            driver.FindElement(By.XPath("//*[@id='Price']")).SendKeys("20");
            //enter save
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            //Validate Edit
            //Goto last page
           // driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            //if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[7]/td[1]")).Text == "wood")
            //{
            // Console.WriteLine("Edited,Test Pased");
        }
        //else
        //{
        //
        // Console.WriteLine("Not edited");
        //}
        public void DeleteTM(IWebDriver driver)
        {
            //Delete function
            //Navigate to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[5]/td[5]/a[2]")).Click();
            //Validate Delete
            IAlert Alert = driver.SwitchTo().Alert();
            Alert.Accept();
        }
    }
}
