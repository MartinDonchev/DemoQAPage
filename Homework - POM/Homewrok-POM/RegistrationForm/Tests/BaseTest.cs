using AutoFixture;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace SelenuimAdvHomework.RegistrationForm.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver _driver { get; set; }

        protected WebDriverWait _wait { get; set; }

        protected Actions _builder { get; set; }

        public void Initialize()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(6));
            _builder = new Actions(_driver);
        }
    }
}
