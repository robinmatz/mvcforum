using OpenQA.Selenium;
using System;

namespace MVCForumAutomation
{
    public class RegistrationPage : FormPage
    {
        public RegistrationPage(IWebDriver webDriver) : base(webDriver)
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

        public string ConfirmPassword
        {
            get { throw new NotImplementedException(); }
            set
            {
                FillInputElement("ConfirmPassword", value);
            }
        }

        public string Email
        {
            get { throw new NotImplementedException(); }
            set
            {
                FillInputElement("Email", value);
            }
        }

        internal void Register()
        {
            var form = WebDriver.FindElement(By.ClassName("form-register"));
            form.Submit();
        }
    }
}