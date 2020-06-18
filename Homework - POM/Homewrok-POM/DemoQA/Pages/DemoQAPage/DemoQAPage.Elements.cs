using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Pages
{
    public partial class DemoQAPage
    {
        protected IWebElement LeftPanel => Driver.FindElement(By.XPath("//*[@class='left-pannel']"));

        public IWebElement InteractionsButton => LeftPanel.FindElement(By.XPath(".//*[normalize-space(text())='Interactions']"));

        public IWebElement SubMenu(string subName) => LeftPanel.FindElement(By.XPath($".//*[normalize-space(text())='{subName}']"));

        public IWebElement PageTitle => Driver.FindElement(By.ClassName("main-header"));
    }
}
