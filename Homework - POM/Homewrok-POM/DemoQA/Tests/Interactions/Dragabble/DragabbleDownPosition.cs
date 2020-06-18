using NUnit.Framework;
using SelenuimAdvHomework.DemoQA.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Tests.Interactions.Dragabble
{
    [TestFixture]
    public class DragabbleDownPosition : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://www.demoqa.com/dragabble");
        }

        [Test]
        public void DragabbleToDownPosition()
        {
            DragabblePage dragabblePage = new DragabblePage(Driver);

            Builder
                .MoveToElement(dragabblePage.dragMeElement)
                .ClickAndHold()
                .MoveByOffset(0, 250)
                .Perform();

            Assert.AreEqual(794, dragabblePage.dragMeElement.Location.Y + 250);

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
