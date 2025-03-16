using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsRegistryPOM.Pages;

namespace StudentsRegistryPOM.PagesTests
{
    public class ViewStudentsPageTests : BaseTests
    {
        [Test]
        public void Test_ViewStudentsPage_Content()
        {
            var viewPage = new ViewStudentsPage(driver);

            viewPage.OpenPage();

            Assert.That(viewPage.GetPageTitle(), Is.EqualTo("Students"));
            Assert.That(viewPage.GetPageHeading(), Is.EqualTo("Registered Students"));

            var students = viewPage.AllRegisterStudents();

            foreach (var student in students)
            {
                Assert.That(student.IndexOf("(") > 0, Is.True);

                Assert.That(student.LastIndexOf(")") == student.Length - 1, Is.True);

            }
        }
        [Test]
        public void Test_ViewStudentsPage_Links()

        {
            var viewPage = new ViewStudentsPage(driver);

            viewPage.OpenPage();

            viewPage.homeLinkElement.Click();
            Assert.That(new HomePage(driver).IsOpen(), Is.True);

            viewPage.OpenPage();
            viewPage.ViemStudentsLinkElement.Click();
            Assert.That(viewPage.IsOpen(), Is.True);

            viewPage.OpenPage();
            viewPage.AddStudentsLinkElement.Click();

            Assert.That(new AddStudentPage(driver).IsOpen, Is.True);

        }



    }
}
    