
//open chrome/firefox browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
//Launch Turn portal and navigate to the website login page
driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
//identify username feildbox and enter username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");
//Identify the login button and click on login button
IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
LoginButton.Click();
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





