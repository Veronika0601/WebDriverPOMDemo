
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace StudentsRegistryPOM.PagesTests
{
    public class BaseTests
    {

        protected IWebDriver driver;

        


        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            this.driver = new ChromeDriver();
           



        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.driver.Quit();
            this.driver.Dispose();
        }
    }

    }
