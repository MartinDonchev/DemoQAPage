using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Pages
{
    public abstract class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Driver.Manage().Window.Maximize();
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(6));
        }

        public virtual string Url { get; }

        public IWebDriver Driver { get; }

        public WebDriverWait Wait { get; }

        public void NaviteTo()
        {
            Driver.Navigate().GoToUrl(Url);
        }

        public void WaitForLoad(int timeoutSec = 15)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
    }
}
