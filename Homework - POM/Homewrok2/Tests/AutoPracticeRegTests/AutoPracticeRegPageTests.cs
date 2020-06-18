using Homewrok2.Pages.AutoPracticeReg;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Homewrok2.Tests.AutoPracticeRegTest
{
    [TestFixture]
    public class AutoPracticeRegPageTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [Test]
        public void FillEmail()
        {
            AutoPracticeRegPage autoPracticeRegPage = new AutoPracticeRegPage(_driver);

            autoPracticeRegPage.SignInButton.Click();
            autoPracticeRegPage.EnterEmail.SendKeys("kiro@gmail.com");
            autoPracticeRegPage.SubmitButton.Click();

            var emailText = _wait.Until(ExpectedConditions.ElementExists(By.XPath("//form[@id='account-creation_form']//input[@id='email']")));
            var regEmailField = autoPracticeRegPage.EmailFieldInRegForm.GetAttribute("value");

            Assert.AreEqual("kiro@gmail.com", regEmailField);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
