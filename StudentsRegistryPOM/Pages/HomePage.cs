using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace StudentsRegistryPOM.Pages
{
    public class HomePage : BasePage
    {

        public HomePage (IWebDriver driver) : base(driver)
        {

        }
        public override string PageURL => "http://localhost:8080/";

        public IWebElement CountStudentsElement => driver.FindElement(By.XPath("//p[text()='Registered students: ']//b"));

        public int GetStudentCount()
        {
            return int.Parse(CountStudentsElement.Text);
        }
    }
}
