using OpenQA.Selenium;

namespace Turnupportal_project.pages
{
    public class Employeepage
    {
        public void CreateEmployeeRecord(IWebDriver driver)
        {

            //create timerecord
            //cretae new button
            Console.WriteLine("Employee Record created");

        }

        public void UpdateEmployeeRecord(IWebDriver driver)
        {
            Console.WriteLine("Employee Record edited");
        }
        public void DeleteEmployeeRecord(IWebDriver driver)
        {
           Console .WriteLine("Employee Record deleted");
        }
    }
}

