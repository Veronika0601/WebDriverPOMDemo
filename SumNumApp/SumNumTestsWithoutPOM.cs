

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SumNumApp
{
    class SumNumTestsWithoutPOM
    {

        IWebDriver driver;
        private SumNumberPage sumPage;


        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            sumPage = new SumNumberPage(driver);

            sumPage.OpenPage();




        }
        [Test]
        public void TestWitCorrectData()
        {
             

            var result = sumPage.SumTwoNumbers("10", "10");

            Assert.That(result, Is.EqualTo("Sum: 20"));


        }

        [Test]
        public void TestWithIncorrecrData()
        {
            
            var result = sumPage.SumTwoNumbers("invalidinput", "10");
          
            Assert.That(result, Is.EqualTo("Sum: invalid input"));


        }
        [Test]

        public void Test_FormReset()
        {
            var result = sumPage.ResetForm("100", "invalidinput");

            Assert.That(result, Is.EqualTo("Reset"));
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
