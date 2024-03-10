using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnupportal_project.pages;
using Newtonsoft.Json.Bson;
using NUnit.Framework;
using Turnupportal_project.utilities;

namespace Turnupportal_project.tests
{
    [TestFixture]
    public class TMTest : Commondriver
    {
        [SetUp]
        public void SetUpTimeAndMaterial()
        {

            driver = new ChromeDriver();
            Loginpage loginpagepageobj = new Loginpage();
            loginpagepageobj.Loginactions(driver, "hari", "123123");

        }
        [Test]
        public void TestCreateTMRecord()
        {
            Homepage Homepageobj = new Homepage();
            Homepageobj.verifyLoggedIntoUser(driver);
            Homepageobj.NavigateToTMPage(driver);

            TimeMaterialpage Timematerialpageobj = new TimeMaterialpage();
            Timematerialpageobj.CreateTMRecord(driver);
        }
        [Test]
        public void TestEditTimeAndMaterialRecord()
        {
            TimeMaterialpage Timematerialpageobj = new TimeMaterialpage();
            Timematerialpageobj.UpdateTMRecord(driver);
        }
        [Test]
        public void TestDeleteTimeAndMaterialRecord()
        {
            TimeMaterialpage Timematerialpageobj = new TimeMaterialpage();
            Timematerialpageobj.DeleteTMRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver .Quit();
        }


    }
       
       
    
}
