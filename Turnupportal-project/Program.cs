
//open chrome/firefox browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

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
//waiting 5 seconds
Thread.Sleep(5000);
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
//..............................................................
//create a new time and material module
//Navigate to time and material module (click on the admin drop down link)

IWebElement Administrationdropdown = driver.FindElement(By.XPath("//*[contains(text(),'Administration')]"));
Administrationdropdown.Click();
IWebElement Timeandmaterialoption = driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));
Timeandmaterialoption.Click();


//cretae new button
IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
CreateNewButton.Click();

IWebElement TypeCodeMainDropDown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
TypeCodeMainDropDown.Click();
Thread.Sleep(5000);
//Select time from the drop down
IWebElement TypeCodeDropDown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
TypeCodeDropDown.Click();

//enter code
IWebElement CodeTextBox = driver.FindElement(By.Id("Code"));
CodeTextBox.SendKeys("sample");

//Enter description
IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
DescriptionTextbox.SendKeys("sample");

//Enter the price
IWebElement PriceTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
PriceTextBox.SendKeys("sample");

//click on the save button
IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
SaveButton.Click();
Thread.Sleep(2000);
//check if the new record have been created succesfully
IWebElement GotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
GotoLastPageButton.Click();

IWebElement NewRecordCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if (NewRecordCode.Text == "sample")
{
    Console.WriteLine("New time/Material is added succesfully");
}
else
{
    Console.WriteLine("New time/Material is not added succesfully");
}


