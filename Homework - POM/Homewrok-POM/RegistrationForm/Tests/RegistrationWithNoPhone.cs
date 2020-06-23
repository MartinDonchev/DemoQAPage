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
    public class RegistrationWithNoPhone : BaseTest
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
        public void Registration_With_NoPhone()
        {
            _user.phoneNumberInCreateForm = String.Empty;
                       
            _registrationFormPage.signInButton.Click();
           
            Driver.ScrollTo(_registrationFormPage.createAccountEmailAdressField);

            _registrationFormPage.createAccountEmailAdressField.SendKeys(_user.createAccountEmailAdressField + "@gmail.com" + Keys.Enter);

            _registrationFormPage.FillForm(_user);

            _registrationFormPage.registerButton.Click();
                        
            var NoPhoneNameError = _registrationFormPage.errorName.Text;

            Assert.IsTrue(NoPhoneNameError.Contains("You must register at least one phone number."));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
