﻿using NUnit.Framework;
using OpenQA.Selenium;
using SelenuimAdvHomework.DemoQA;
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
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(" http://automationpractice.com/index.php");
            _registrationFormPage = new RegistrationFormPage(_driver);
            _user = UserFactory.CreateValidUser();
        }

        [Test]
        public void Registration_With_NoLastName()
        {
            _user.lastNameInCreateAccount = String.Empty;
            
            _registrationFormPage.signInButton.Click();
            
            _driver.ScrollTo(_registrationFormPage.createAccountEmailAdressField);

            _registrationFormPage.createAccountEmailAdressField.SendKeys(_user.createAccountEmailAdressField + "@gmail.com" + Keys.Enter);

            _registrationFormPage.FillForm(_user);

            _registrationFormPage.registerButton.Click();

            var LastNameError = _registrationFormPage.errorName.Text;

            Assert.IsTrue(LastNameError.Contains("lastname is required"));
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
