using Homewrok2.Pages.QAAutomation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homewrok2.Tests.QAAutomationTests
{
    [TestFixture]
    public class QAAutomationPageTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://www.softuni.bg");
        }

        [Test]
        public void QAAutomation()
        {
            QAAutomationPage qAAutomationPage = new QAAutomationPage(_driver);

            qAAutomationPage.Courses.Click();
            qAAutomationPage.PlusButton.Click();
            qAAutomationPage.QaCourseLink.Click();

            var actualHeader = qAAutomationPage.HeadingTag.Text;

            Assert.IsTrue(actualHeader.Contains("Quality Assurance - октомври 2019"));
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

    }
}
