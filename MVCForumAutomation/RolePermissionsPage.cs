using OpenQA.Selenium;
using System.Linq;

namespace MVCForumAutomation
{
    internal class RolePermissionsPage
    {
        private readonly IWebDriver _webDriver;
        public RolePermissionsPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        internal void AddCategory(Category category, PermissionTypes permissionType)
        {
            var permissionsTable = _webDriver.FindElement(By.ClassName("permissiontable"));

            var categoryRows = permissionsTable.FindElements(By.CssSelector(".permissiontable tbody tr"));
            var categoryRow = categoryRows.Single(row => row.FindElement(By.XPath("./td")).Text == category.Name);

            var permissionCheckboxes = categoryRow.FindElements(By.CssSelector(".permissioncheckbox input"));
            var permissionCheckbox = permissionCheckboxes[(int)permissionType];
            if (!permissionCheckbox.Selected)
            {
                permissionCheckbox.Click();
            }
        }
    }
}
