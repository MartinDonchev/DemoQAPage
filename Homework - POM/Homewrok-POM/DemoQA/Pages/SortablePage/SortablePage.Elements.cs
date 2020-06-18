using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Pages
{
    public partial class SortablePage
    {
        public List<IWebElement> listOfoptions => Driver.FindElements
           (By.XPath("//div[@id='demo-tabpane-list']//div[contains(@class,'list-group-item ')]")).ToList();
    }
}
