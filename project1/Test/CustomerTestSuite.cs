using Helpers;
using NUnit.Framework;
using project1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.Test
{
               [TestFixture,Description("Collection of Test Within CustomerPage")]
    [Parallelizable]
    class CustomerPageTestSuite : CommonDriver
        {
            [Test,Description("Validate Create CustomerPage with valid Data")]
            public void CreateCustomerTest()
            {
                CustomerPage custObj = new CustomerPage();
            custObj.CreateCustomer(driver);
            }
            [Test, Description("Validate Edit CustomerPage with valid Data")]
            //Edit 
            public void EditCustomerTest()
            {
                CustomerPage custObj = new CustomerPage();
                custObj.EditCustomer(driver);
            }
            [Test, Description("Validate Delete CustomerPage with valid Data")]
            //Delete
            public void DeleteCustomerTest()
            {
                CustomerPage custObj = new CustomerPage();
                custObj.DeleteCustomer(driver);
            }
        }
    }

