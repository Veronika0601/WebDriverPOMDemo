

using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace StudentsRegistryPOM.Pages
{
    public class ViewStudentsPage : BasePage
    {

        public ViewStudentsPage(IWebDriver driver) : base(driver) { }

        public override string PageURL => "http://localhost:8080/students";

        public ReadOnlyCollection<IWebElement> ListOfStudents => driver.FindElements(By.XPath("//ul/li"));

        public string[] AllRegisterStudents()
        {
            var studentsElements = ListOfStudents.Select(s => s.Text).ToArray();

            return studentsElements;
        }



    }
}
