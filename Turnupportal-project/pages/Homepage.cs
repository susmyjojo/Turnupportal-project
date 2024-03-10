using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Turnupportal_project.utilities;

namespace Turnupportal_project.pages
{
    public class Homepage
    {
        public  void NavigateToTMPage(IWebDriver driver)
        {
            //create a new time and material module
            //Navigate to time and material module (click on the admin drop down link)

            IWebElement Administrationdropdown = driver.FindElement(By.XPath("//*[contains(text(),'Administration')]"));
            Administrationdropdown.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible (By.XPath("//a[contains(text(),'Time & Materials')]"));
            Waitutils.WaitToBeVisible(driver, "xpath", "//a[contains(text(),'Time & Materials')]", 3);

            IWebElement Timeandmaterialoption = driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));
            Timeandmaterialoption.Click();
        }

        
        
            public void NavigateToEmployeePage(IWebDriver driver)
            {
                //create a new time and material module
                //Navigate to time and material module (click on the admin drop down link)

                IWebElement Administrationdropdown = driver.FindElement(By.XPath("//*[contains(text(),'Administration')]"));
                Administrationdropdown.Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible (By.XPath("//a[contains(text(),'Time & Materials')]"));
                Waitutils.WaitToBeVisible(driver, "xpath", "//a[contains(text(),'Time & Materials')]", 3);

                IWebElement Employeeoption = driver.FindElement(By.XPath("//a[contains(text(),'Employees')]"));
                Employeeoption.Click();
            }

            public void verifyLoggedIntoUser(IWebDriver driver)
        {
            //check if the user logged in successfully
            IWebElement HelloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            if (HelloHari.Text == "Hellow Hari")
            {
                Console.WriteLine("User has logged in Successfully");
            }
            else
            {
                Console.WriteLine("User hasn't been logged successfully");
            }
        }
    }
}
