using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Support.UI;
using SelenuimAdvHomework.RegistrationForm.Pages;
using SelenuimAdvHomework.DemoQA;
using System.Threading;
using SelenuimAdvHomework.RegistrationForm.Models;
using SelenuimAdvHomework.DemoQA.Tests;

namespace SelenuimAdvHomework.RegistrationForm.Tests
{
    [TestFixture]
    public class InvalidPassword : BaseTest
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
        public void Registration_With_PasswordLessThenFiveSymbols()
        {
            _user.passwordInCreateAccount = "1234";
            
            _registrationFormPage.signInButton.Click();

            Driver.ScrollTo(_registrationFormPage.createAccountEmailAdressField);

            _registrationFormPage.createAccountEmailAdressField.SendKeys(_user.createAccountEmailAdressField + "@gmail.com" + Keys.Enter);
            
            _registrationFormPage.FillForm(_user);

            _registrationFormPage.registerButton.Click();
            
            var PassError = _registrationFormPage.errorName.Text;

            Assert.AreEqual("passwd is invalid.", PassError);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
