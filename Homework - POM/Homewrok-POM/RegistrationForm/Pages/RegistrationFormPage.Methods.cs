using Fare;
using OpenQA.Selenium;
using SelenuimAdvHomework.DemoQA;
using SelenuimAdvHomework.DemoQA.Pages;
using SelenuimAdvHomework.RegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace SelenuimAdvHomework.RegistrationForm.Pages
{
    public partial class RegistrationFormPage : BasePage
    {
        private object _driver;
        private RegistrationFormModel _user;

        public RegistrationFormPage(IWebDriver driver)
            : base(driver)
        {

        }

        public void FillForm(RegistrationFormModel user)
        {
           
            createAccountEmailAdressField.SendKeys(user.createAccountEmailAdressField);

            firstNameInCreateAccountForm.SendKeys(user.firstNameInCreateAccount);

            lastNameInCreateAccountForm.SendKeys(user.lastNameInCreateAccount);

            passwordInCreateAccount.SendKeys(user.passwordInCreateAccount);

            addressInCreateAccount.SendKeys(user.addressInCreateAccount);

            cityInCreateAccount.SendKeys(user.cityInCreateAccount);

            stateInCreateAccount.SendKeys(user.stateInCreateAccount);

            postalCodeInCreateAccount.SendKeys(user.postalCodeInCreateAccount);

            countryInCreateAccount.SendKeys(user.countryInCreateAccount);

            phoneNumberInCreateForm.SendKeys(user.phoneNumberInCreateForm);

            assignAddressInCreateForm.SendKeys(user.assignAddressInCreateForm);

        }

        public void NavigateToRegForm()
        {
            _user = UserFactory.CreateValidUser();

            signInButton.Click();

            Driver.ScrollTo(createAccountEmailAdressField);

            createAccountEmailAdressField.SendKeys(_user.createAccountEmailAdressField + "@gmail.com" + Keys.Enter);
        }

    } 
}

