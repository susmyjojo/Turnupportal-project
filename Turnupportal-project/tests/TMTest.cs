using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Turnupportal_project.pages;
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
        [Test,Order(1), Description("This test create TM record valid details")]
        public void TestCreateTMRecord()
        {
            Homepage Homepageobj = new Homepage();
            Homepageobj.verifyLoggedIntoUser(driver);
            Homepageobj.NavigateToTMPage(driver);

            TimeMaterialpage Timematerialpageobj = new TimeMaterialpage();
            Timematerialpageobj.CreateTMRecord(driver);
        }
        [Test,Order(2), Description("This test edit TM record valid details")]
        public void TestEditTimeAndMaterialRecord()
        {
            TimeMaterialpage Timematerialpageobj = new TimeMaterialpage();
            Timematerialpageobj.UpdateTMRecord(driver);
        }
        [Test,Order(3), Description("This test delete TM record valid details")]
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
