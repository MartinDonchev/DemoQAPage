using NUnit.Framework;
using SelenuimAdvHomework.DemoQA.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Tests.Interactions.Droppale
{
    [TestFixture]
    public class DroppableElementChangeColor : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://www.demoqa.com/droppable");
        }

        [Test]
        public void DropBoxChangeColor_WhenDragBoxMoveToBox()
        {
            DroppablePage dropPage = new DroppablePage(Driver);

            Builder
                .MoveToElement(dropPage.dragMeBox)
                .ClickAndHold()
                .DragAndDrop(dropPage.dragMeBox, dropPage.dropHereBox)
                .Perform();

            var colorOfDropBox = "rgba(70, 130, 180, 1)";

            Assert.AreEqual(colorOfDropBox, dropPage.dropBoxInnerText.GetCssValue("background-color"));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
