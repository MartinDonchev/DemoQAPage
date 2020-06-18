using NUnit.Framework;
using SelenuimAdvHomework.DemoQA.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Tests.Selectable
{
    [TestFixture]
    public class ChangeColor_WhenSelectingTwoFields : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://www.demoqa.com/selectable");
        }

        [Test]
    
        public void ChangeColor_WhenSelectingTwo()
        {
            SelectablePage selectPage = new SelectablePage(Driver);

            selectPage.FirstSelectedElement.Click();
            selectPage.SecondSelectedElement.Click();

            var firstElementColor = selectPage.FirstSelectedElement.GetCssValue("background-color");
            var secondElementColor = selectPage.SecondSelectedElement.GetCssValue("background-color");

            Assert.AreEqual(firstElementColor, secondElementColor);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
