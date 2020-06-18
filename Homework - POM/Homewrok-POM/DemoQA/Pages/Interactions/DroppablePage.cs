using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Pages
{
    public class DroppablePage : BasePage
    {
        public DroppablePage(IWebDriver driver)
            :base(driver)
        {

        }

        public IWebElement dragMeBox => Driver.FindElement(By.Id("draggable"));

        public IWebElement dropHereBox => Driver.FindElement(By.Id("droppable"));

        public IWebElement dropBoxInnerText => Driver.FindElement(By.XPath("//div[@id='simpleDropContainer']//div[@id='droppable']"));
    }
}
