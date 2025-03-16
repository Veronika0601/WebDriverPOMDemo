

using StudentsRegistryPOM.Pages;

namespace StudentsRegistryPOM.PagesTests
{
    public class HomePageTests :BaseTests
    {

        [Test]

        public void Correct_HomePage_Content()
        {
            var homePage = new HomePage(driver);

            homePage.OpenPage();

            Assert.That(homePage.GetPageTitle(), Is.EqualTo("MVC Example"));
            Assert.That(homePage.GetPageHeading(), Is.EqualTo("Students Registry"));

            Assert.That(homePage.GetStudentCount(), Is.GreaterThan(3));


           
        }

        [Test]
        public void Test_HomePage_Links()
        {
            var homePage = new HomePage(driver);
            homePage.OpenPage();

            homePage.homeLinkElement.Click();

            Assert.That(homePage.IsOpen(), Is.True);

            homePage.OpenPage();

            homePage.ViemStudentsLinkElement.Click();
            Assert.That(new ViewStudentsPage (driver).IsOpen(), Is.True);

            homePage.OpenPage();
            homePage.AddStudentsLinkElement.Click();

            Assert.That(new AddStudentPage(driver).IsOpen(), Is.True);
        }



    }
}
