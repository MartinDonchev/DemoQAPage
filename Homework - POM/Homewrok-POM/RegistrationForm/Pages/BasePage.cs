using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.RegistrationForm.Pages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(8));
        }

        public IWebDriver Driver { get; }

        public WebDriverWait Wait { get; }
    }
}
