
//open chrome/firefox browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Turnupportal_project.pages;

public class Program
{
    private static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        Loginpage loginpagepageobj = new Loginpage();
        loginpagepageobj.Loginactions(driver ,"hari" ,"123123");

        Homepage Homepageobj = new Homepage();
        Homepageobj.verifyLoggedIntoUser(driver);
        Homepageobj.NavigateToTMPage(driver);

        TimeMaterialpage Timematerialpageobj = new TimeMaterialpage();
        Timematerialpageobj.CreateTMRecord(driver);
        Timematerialpageobj.UpdateTMRecord(driver);
        Timematerialpageobj.DeleteTMRecord(driver);



    }
}


        