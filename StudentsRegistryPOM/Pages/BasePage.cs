

using OpenQA.Selenium;

namespace StudentsRegistryPOM.Pages
{
    public class BasePage
    {

        protected readonly IWebDriver driver;

        public virtual string PageURL { get; }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public IWebElement homeLinkElement => driver.FindElement(By.XPath("//a[text()='Home']"));
        public IWebElement ViemStudentsLinkElement => driver.FindElement(By.XPath("//a[text()='View Students']"));

        public IWebElement AddStudentsLinkElement => driver.FindElement(By.XPath(" //a[text()='Add Student']"));

        public IWebElement PageHeading => driver.FindElement(By.TagName("h1"));

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageURL);
        }
        public bool IsOpen()
        {
            return driver.Url == this.PageURL;
        }
        public string GetPageTitle()
        {
            return driver.Title;
        }

        public string GetPageHeading()

        {
            return PageHeading.Text;
        }
        
    }
}
