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
    [Parallelizable]
    [TestFixture]
    public class EmployeeTest : Commondriver
    {
        [SetUp]
        public void SetUpTimeAndMaterial()
        {

            driver = new ChromeDriver();
            Loginpage loginpagepageobj = new Loginpage();
            loginpagepageobj.Loginactions(driver, "hari", "123123");

            Homepage Homepageobj = new Homepage();
            Homepageobj.verifyLoggedIntoUser(driver);
            Homepageobj.NavigateToEmployeePage(driver);

        }
        [Test]
        public void TestCreateEmployeeRecord()
        {

            Employeepage Timematerialpageobj = new Employeepage();
            Timematerialpageobj.CreateEmployeeRecord(driver);
        }
        [Test]
        public void TestEditEmployeeRecord()
        {
            Employeepage Timematerialpageobj = new Employeepage();
            Timematerialpageobj.UpdateEmployeeRecord(driver);
        }
        [Test]
        public void TestDeleteEmployeeRecord()
        {
            Employeepage Timematerialpageobj = new Employeepage();
            Timematerialpageobj.DeleteEmployeeRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver .Quit();
        }


    }
       
       
    
}
