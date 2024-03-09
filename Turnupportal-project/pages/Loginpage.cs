using OpenQA.Selenium;

namespace Turnupportal_project.pages
{
    public class Loginpage
    {
        private readonly By UsernameTextBoxLocator = By.Id("UserName");
        IWebElement usernameTextbox;
        private readonly By PasswordTextBoxLocator = By.Id("Password");
        IWebElement passwordTextbox;
        private readonly By LoginButtonLocator =By.XPath("//*[@id='loginForm']/form/div[3]/input[1]");
        IWebElement LoginButton;
        public void Loginactions(IWebDriver driver, string username ,string password)
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts() .ImplicitWait = TimeSpan.FromSeconds(5);
            //Launch Turn portal and navigate to the website login page
            string baseURL = "http://horse.industryconnect.io/";
            driver.Navigate().GoToUrl(baseURL);
            //identify username feildbox and enter username
            usernameTextbox = driver.FindElement(UsernameTextBoxLocator);
            usernameTextbox.SendKeys(username);
            passwordTextbox = driver.FindElement(PasswordTextBoxLocator);
            passwordTextbox.SendKeys(password);
            //Identify the login button and click on login button
            //waiting 5 seconds
            Thread.Sleep(5000);
            LoginButton = driver.FindElement(LoginButtonLocator);
            LoginButton.Click();
        }
    }
}
