using Helpers;
using NUnit.Framework;
using project1.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.Test
{
    [TestFixture, NUnit.Framework.Description("Collection of Test withinTMpage")]
    [Parallelizable]
    class TimeMaterialTestSuite : CommonDriver
    {
             [Test, NUnit.Framework.Description("Validate Create Within TMPage")]
            public void CreateTM()
            {
                TMPage tmObj = new TMPage();
                tmObj.CreateTM(driver);
            }
            [Test, NUnit.Framework.Description("Validate Edit Within TMPage")]
            //Edit 
            public void EditTM()
            {
                TMPage tmObj = new TMPage();
                tmObj.EditTM(driver);
            }
            [Test, NUnit.Framework.Description("Validate Delete Within TMPage")]
            //Delete
            public void DeleteTM()
            {
                TMPage tmObj = new TMPage();
                tmObj.DeleteTM(driver);
            }
        }
    }

