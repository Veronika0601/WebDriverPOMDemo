

using OpenQA.Selenium;

namespace SumNumApp
{
    public class SumNumberPage
    {

        private IWebDriver driver;

        public SumNumberPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        const string pageURL = "file:///C:/Users/veron/Desktop/ResourcesDemo/Sum-Num/sum-num.html";
        public IWebElement fieldNum1 => driver.FindElement(By.CssSelector("[name=number1]"));

        public IWebElement fieldNum2 => driver.FindElement(By.CssSelector("[name=number2]"));

        public IWebElement calculateButton => driver.FindElement(By.CssSelector("[type=button]"));

        public IWebElement resultElement => driver.FindElement(By.XPath("//div[@id='result']"));

        public IWebElement resetButton => driver.FindElement(By.CssSelector("[type='Reset']"));
        

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(pageURL);
        }



        public string SumTwoNumbers(string number1, string number2)
        {
            fieldNum1.SendKeys(number1);
            fieldNum2.SendKeys(number2);
            calculateButton.Click();

            string result = resultElement.Text;

            return result;

        }
        public string ResetForm(string number1, string number2)
        {
            fieldNum1.SendKeys(number1);
            fieldNum2.SendKeys(number2);
            resetButton.Click();
            

          if(string.IsNullOrEmpty(fieldNum1.GetAttribute("value")) && string.IsNullOrEmpty(fieldNum2.GetAttribute("value")))
            {
                return "Reset";
            }
            else
            {
                return "Reset failed";
            }

        }

    }
}
