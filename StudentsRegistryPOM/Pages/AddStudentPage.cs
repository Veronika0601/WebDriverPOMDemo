using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace StudentsRegistryPOM.Pages
{
    public class AddStudentPage:BasePage
    {
        public AddStudentPage(IWebDriver driver) : base(driver) { }

        public override string PageURL => "http://localhost:8080/add-student";

        public IWebElement nameField => driver.FindElement(By.CssSelector("[id='name']"));
        public IWebElement emailField => driver.FindElement(By.CssSelector("[id='email']"));

        public IWebElement addButton => driver.FindElement(By.XPath("//button[@type='submit']"));

        public IWebElement errorMessage => driver.FindElement(By.XPath("//div[text()='Cannot add student. Name and email fields are required!']"));


        public void AddStudent(string name, string email)
        {
            this.nameField.SendKeys(name);
            this.emailField.SendKeys(email);

            addButton.Click();
        }




    }
}
