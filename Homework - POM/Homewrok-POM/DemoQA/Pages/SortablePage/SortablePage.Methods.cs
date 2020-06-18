using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Pages
{
    public partial class SortablePage : DemoQAPage
    {
        public SortablePage(IWebDriver driver)
           : base(driver)
        {
        }

        public override string Url => "http://demoqa.com/sortable";
    }
}
