using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SelenuimAdvHomework.DemoQA.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.RegistrationForm.Pages
{
    public partial class RegistrationFormPage : BasePage
    {       

        public IWebElement signInButton => Wait.Until(d => d.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a")));

        public IWebElement createAccountEmailAdressField => Wait.Until(d => d.FindElement(By.XPath("//*[@id='email_create']")));

        public IWebElement firstNameInCreateAccountForm => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("customer_firstname")));

        public IWebElement lastNameInCreateAccountForm => Wait.Until(d => d.FindElement(By.Id("customer_lastname")));

        public IWebElement passwordInCreateAccount => Wait.Until<IWebElement>(p => p.FindElement(By.Id("passwd")));

        public IWebElement addressInCreateAccount => Wait.Until<IWebElement>(p => p.FindElement(By.Id("address1")));

        public IWebElement cityInCreateAccount => Wait.Until<IWebElement>(p => p.FindElement(By.Id("city")));

        public IWebElement stateInCreateAccount => Wait.Until<IWebElement>(p => p.FindElement(By.Id("id_state")));

        public IWebElement postalCodeInCreateAccount => Wait.Until<IWebElement>(p => p.FindElement(By.Id("postcode")));

        public IWebElement countryInCreateAccount => Wait.Until<IWebElement>(p => p.FindElement(By.Id("id_country")));

        public IWebElement phoneNumberInCreateForm => Wait.Until<IWebElement>(e => e.FindElement(By.Id("phone_mobile")));

        public IWebElement assignAddressInCreateForm => Wait.Until<IWebElement>(d => d.FindElement(By.Id("alias")));

        public IWebElement registerButton => Driver.FindElement(By.XPath("//*[@id='submitAccount']/span"));

        public IWebElement namesOfLoggedUser => Driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]"));

        public IWebElement errorName => Driver.FindElement(By.XPath("//div[@class='alert alert-danger']//li"));
    }
}
