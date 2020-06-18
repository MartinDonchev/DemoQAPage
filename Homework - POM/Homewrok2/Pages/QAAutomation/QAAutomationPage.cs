using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homewrok2.Pages.QAAutomation
{
    //With FindsBy and PageFactory
    public class QAAutomationPage 
    {
        private IWebDriver _driver;

        public QAAutomationPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public IWebDriver Driver => _driver;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/a/span")]
        public IWebElement Courses { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='header-nav']/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/div/div[1]/i")]
        public IWebElement PlusButton { get; set; }

        [FindsBy(How = How.LinkText, Using = "Quality Assurance - октомври 2019")]
        public IWebElement QaCourseLink { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/header/h1")]
        public IWebElement HeadingTag { get; set; }
    }
}
