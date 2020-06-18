using NUnit.Framework;
using SelenuimAdvHomework.DemoQA.Pages;
using SelenuimAdvHomework.DemoQA.Pages.HomePage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Tests.Interactions
{
    public class NavigationTests : BaseTest
    {
        private HomePage _homePage;
        private SortablePage _sortablePage;
        private DemoQAPage _demoQaPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _homePage = new HomePage(Driver);
            _sortablePage = new SortablePage(Driver);
            _demoQaPage = new DemoQAPage(Driver);
            _homePage.NaviteTo();
        }

        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        public void SuccessfullyPageLoaded_When_NavigateToSortable(string sectionName)
        {
            _homePage.CategotyButton("Interactions").Click();

            Driver.ScrollTo(_sortablePage.InteractionsButton);
            
            _demoQaPage.SubMenu(sectionName).Click();
            
            _demoQaPage.AssertPageTitle(sectionName);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
