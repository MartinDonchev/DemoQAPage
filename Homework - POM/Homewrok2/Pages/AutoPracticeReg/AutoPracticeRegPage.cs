using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homewrok2.Pages.AutoPracticeReg
{
    public class AutoPracticeRegPage : BasePage
    {       

        public AutoPracticeRegPage(IWebDriver driver)
            : base(driver)
        {
                
        }

        public IWebElement SignInButton => Driver.FindElement(By.XPath("//*[@class='login']"));

        public IWebElement EnterEmail => Wait.Until(d => d.FindElement(By.XPath("//*[@id='email_create']")));

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        public IWebElement SubmitButton => Driver.FindElement(By.Id("SubmitCreate"));

        public IWebElement EmailFieldInRegForm => Driver.FindElement(By.XPath("//form[@id='account-creation_form']//input[@id='email']"));

    }
}
