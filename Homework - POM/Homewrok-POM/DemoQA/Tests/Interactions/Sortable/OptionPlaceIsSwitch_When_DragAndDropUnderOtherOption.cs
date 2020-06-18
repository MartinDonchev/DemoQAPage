using NUnit.Framework;
using SelenuimAdvHomework.DemoQA.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Tests.Sortable
{
    [TestFixture]
    public class OptionPlaceIsSwitch_When_DragAndDropUnderOtherOption : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://www.demoqa.com/sortable");
        }

        [Test]
        public void PlaceIsSwitch_When_DragAndDropUnderOtherOption()
        {
            SortablePage sortPage = new SortablePage(Driver);

            var index = 1;

            Builder
                .DragAndDropToOffset(sortPage.listOfoptions[index], 0, 50)
                .Perform();

            sortPage.AssertTextByIndex("Two", index + 1);
            
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
