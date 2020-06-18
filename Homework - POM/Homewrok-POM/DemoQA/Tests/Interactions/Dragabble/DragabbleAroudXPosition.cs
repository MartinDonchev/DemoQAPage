using NUnit.Framework;
using SelenuimAdvHomework.DemoQA.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Tests.Interactions.Dragabble
{
    [TestFixture]
    public class DragabbleAroudXPosition : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://www.demoqa.com/dragabble");
        }

        [Test]
        public void DragabbleAroundX()
        {
            DragabblePage dragabblePage = new DragabblePage(Driver);

            dragabblePage.axisRestrictedTab.Click();

            var onlyYBox = dragabblePage.onlyXBoxY;
            var xBefore = onlyYBox.Location.X;
            Builder.DragAndDropToOffset(onlyYBox, 100, 100).Perform();
            var xAfter = onlyYBox.Location.X;

            Assert.AreEqual(xBefore, xAfter);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
