using Homewrok2.Pages.GoogleSearch;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homewrok2.Tests.GoogleSearchTests
{
    [TestFixture]
    public class GoogleSearchPageTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://www.google.com");
        }

        [Test]
        public void SeleniumSearch()
        {
            GoogleSearchPage googleSearchPage  = new GoogleSearchPage(_driver);

            googleSearchPage.SearchField.SendKeys("Selenium" + Keys.Enter);

            var firstFoundItem = googleSearchPage.FirstFoundItem.Text;

            var searchedItemName = "Selenium - Web Browser Automation";

            Assert.AreNotEqual(searchedItemName, firstFoundItem);
            Assert.IsTrue(firstFoundItem.Contains("Selenium"));
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
