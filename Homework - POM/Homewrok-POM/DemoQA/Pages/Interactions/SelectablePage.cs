using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Pages
{
    public class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver)
            : base(driver)
        {

        }

        public IWebElement FirstSelectedElement => Driver.FindElement(By.XPath("//*[@id='verticalListContainer']/li[1]"));

        public IWebElement SecondSelectedElement => Driver.FindElement(By.XPath("//*[@id='verticalListContainer']/li[2]"));

    }
}
