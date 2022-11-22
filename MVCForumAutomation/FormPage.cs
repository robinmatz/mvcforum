using OpenQA.Selenium;

namespace MVCForumAutomation
{
    public class FormPage
    {
        protected readonly IWebDriver WebDriver;

        public FormPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public void FillInputElement(string id, string value)
        {
            var emailInput = WebDriver.FindElement(By.Id(id));
            emailInput.SendKeys(value);
        }
    }
}