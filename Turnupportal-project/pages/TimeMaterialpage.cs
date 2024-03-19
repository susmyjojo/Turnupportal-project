using NUnit.Framework;
using OpenQA.Selenium;
using Turnupportal_project.utilities;

namespace Turnupportal_project.pages
{
    public class TimeMaterialpage
    {
        public void CreateTMRecord(IWebDriver driver)
        {

            //create timerecord
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
           // Waitutils.WaitToBeClickable(driver, "XPath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]", 1);
            IWebElement PriceTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            PriceTextBox.SendKeys("sample");

            //click on the save button
            Waitutils.WaitToBeVisible(driver, "Id", "SaveButton", 2);
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
            Thread.Sleep(2000);
            //check if the new record have been created succesfully
            IWebElement GotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            GotoLastPageButton.Click();

            IWebElement NewRecordCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (NewRecordCode.Text == "sample")
            {
                Assert.Pass("New time/Material is added succesfully");
            }
            else
            {
               Assert.Fail("New time/Material is not added succesfully");
            }
        }


        public void UpdateTMRecord(IWebDriver driver)
        {

        }
        public void DeleteTMRecord(IWebDriver driver)
        {

        }
    }
}

