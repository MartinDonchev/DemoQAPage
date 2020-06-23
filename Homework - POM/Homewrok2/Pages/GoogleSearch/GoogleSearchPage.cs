using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homewrok2.Pages.GoogleSearch
{
    //With FindsBy and PageFactory - hard way
    public class GoogleSearchPage
    {
        private IWebDriver _driver;
        public GoogleSearchPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public IWebDriver Driver => _driver;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[@name='q']")]
        public IWebElement SearchField { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//*[@id='rso']/div[1]")]
        public IWebElement FirstFoundItem { get; set; }
    }
}
