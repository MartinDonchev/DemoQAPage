using NUnit.Framework;
using SelenuimAdvHomework.DemoQA.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Tests.Interactions.Dragabble
{
    [TestFixture]
    public class DragabbleAroudYPosition : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://www.demoqa.com/dragabble");
        }

        [Test]
        public void DragabbleAroundY()
        {
            DragabblePage dragabblePage = new DragabblePage(Driver);

            dragabblePage.axisRestrictedTab.Click();

            var onlyXBox = dragabblePage.onlyXBoxX;
            var yBefore = onlyXBox.Location.Y;
            Builder.DragAndDropToOffset(onlyXBox, 100, 100).Perform();
            var yAfter = onlyXBox.Location.Y;

            Assert.AreEqual(yBefore, yAfter);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
