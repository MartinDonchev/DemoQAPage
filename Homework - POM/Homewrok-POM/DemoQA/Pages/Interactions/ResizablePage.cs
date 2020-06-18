using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Pages
{
    public class ResizablePage : BasePage
    {
        public ResizablePage(IWebDriver driver)
            : base(driver)
        {

        }

        public IWebElement container => Driver.FindElement(By.ClassName("constraint-area"));
        public IWebElement resizableBox => Driver.FindElement(By.Id("resizableBoxWithRestriction"));
        public IWebElement resizableArrow => Driver.FindElement(By.XPath("//div[@id ='resizableBoxWithRestriction']/span"));
    }
}
