using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnupportal_project.utilities
{
    public class Waitutils
    {
        public static void WaitToBeVisible(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            if (locatorType == "xpath")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }
            if (locatorType == "Id")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
            }
            if (locatorType == "CssSelector")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));
            }
            if (locatorType == "Name")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(locatorValue)));
            }
        }
    }
}


