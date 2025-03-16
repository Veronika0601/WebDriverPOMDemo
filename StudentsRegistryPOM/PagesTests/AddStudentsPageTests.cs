using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsRegistryPOM.Pages;

namespace StudentsRegistryPOM.PagesTests
{
    public class AddStudentsPageTests:BaseTests
    {
        [Test]
        public void Test_TestAddStudentPage_Content()
        {
            var addStudentPage = new AddStudentPage(driver);

            addStudentPage.OpenPage();

            Assert.That(addStudentPage.GetPageTitle(), Is.EqualTo("Add Student"));
            Assert.That(addStudentPage.GetPageHeading(), Is.EqualTo("Register New Student"));

            Assert.That(addStudentPage.nameField.GetAttribute("value"), Is.Empty, "Input Field 1 is not empty.");
            Assert.That(addStudentPage.emailField.GetAttribute("value"), Is.Empty, "Input Field 2 is not empty.");


            Assert.That(addStudentPage.addButton.Text, Is.EqualTo("Add"));
        }

        [Test]

        public void Test_TestAddStudentPage_Links()
        {
            var addStudentPage = new AddStudentPage(driver);

            addStudentPage.OpenPage();


            addStudentPage.ViemStudentsLinkElement.Click();
            Assert.That(new ViewStudentsPage(driver).IsOpen(), Is.True);


            addStudentPage.OpenPage();

            addStudentPage.ViemStudentsLinkElement.Click();

            Assert.That(new ViewStudentsPage(driver).IsOpen, Is.True);

            addStudentPage.OpenPage();
            addStudentPage.AddStudentsLinkElement.Click();
            Assert.That(addStudentPage.IsOpen, Is.True);

        }
        [Test]
        public void Test_TestAddStudentPage_AddValidStudent()
        {
            var addStudentPage = new AddStudentPage(driver);

            addStudentPage.OpenPage();


            string name = "New student" + DateTime.Now.Ticks;
            string email = "email" + DateTime.Now.Ticks + "@gmail.com";

            addStudentPage.AddStudent(name, email);

            var studentPage = new ViewStudentsPage(driver);

            Assert.That(studentPage.GetPageTitle(), Is.EqualTo("Students"), "The page title is not correct.");

            var studentList = studentPage.AllRegisterStudents();

            var studentFound = studentList.Any(s => s.Contains(name) && s.Contains(email));
            Assert.That(studentFound, Is.True, "The newly added student was not found in the list.");


        }
        [Test]
        public void Test_TestAddStudentPage_AddInvalidStudent()
        {
            var addStudentPage = new AddStudentPage(driver);

            addStudentPage.OpenPage();

            string name = "";
            string email = "email" + DateTime.Now.Ticks + "@gmail.com";


            addStudentPage.AddStudent(name,email);
            Assert.That(addStudentPage.GetPageTitle(), Is.EqualTo("Add Student"), "The page title is not correct.");
          

            Assert.That(addStudentPage.errorMessage.Text, Does.Contain("Cannot add student."), "The error message does not contain the expected text.");

        }

    }
}
