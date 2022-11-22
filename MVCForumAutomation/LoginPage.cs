using OpenQA.Selenium;
using System;

namespace MVCForumAutomation
{
    public class LoginPage : FormPage
    {
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public string UserName
        {
            get { throw new NotImplementedException(); }
            set
            {
                FillInputElement("UserName", value);
            }
        }

        public string Password
        {
            get { throw new NotImplementedException(); }
            set
            {
                FillInputElement("Password", value);
            }
        }

        internal void LogOn()
        {
            var form = WebDriver.FindElement(By.ClassName("form-login"));
            form.Submit();
        }
    }
}