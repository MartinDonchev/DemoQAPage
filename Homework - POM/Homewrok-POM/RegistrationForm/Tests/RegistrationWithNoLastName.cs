using NUnit.Framework;
using OpenQA.Selenium;
using SelenuimAdvHomework.DemoQA;
using SelenuimAdvHomework.DemoQA.Tests;
using SelenuimAdvHomework.RegistrationForm.Models;
using SelenuimAdvHomework.RegistrationForm.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SelenuimAdvHomework.RegistrationForm.Tests
{
    [TestFixture]
    public class RegistrationWithNoLastName : BaseTest
    {
        private RegistrationFormModel _user;
        private RegistrationFormPage _registrationFormPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(" http://automationpractice.com/index.php");
            _registrationFormPage = new RegistrationFormPage(Driver);
            _user = UserFactory.CreateValidUser();
        }

        [Test]
        public void Registration_With_NoLastName()
        {
            _user.lastNameInCreateAccount = String.Empty;

            _registrationFormPage.NavigateToRegForm();
            _registrationFormPage.FillForm(_user);
            _registrationFormPage.registerButton.Click();

            var LastNameError = _registrationFormPage.errorName.Text;

            Assert.IsTrue(LastNameError.Contains("lastname is required"));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
