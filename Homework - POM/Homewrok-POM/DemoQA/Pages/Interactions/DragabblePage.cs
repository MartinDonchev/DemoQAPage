using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Pages
{
    public class DragabblePage : BasePage
    {
        public DragabblePage(IWebDriver driver)
            :base(driver)
        {

        }

        public IWebElement dragMeElement => Driver.FindElement(By.XPath("//*[@id='dragBox']"));

        public IWebElement axisRestrictedTab => Driver.FindElement(By.Id("draggableExample-tab-axisRestriction"));

        public IWebElement onlyXBoxX => Driver.FindElement(By.Id("restrictedX"));

        public IWebElement onlyXBoxY => Driver.FindElement(By.Id("restrictedY"));

    }
}
