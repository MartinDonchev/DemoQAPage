using NUnit.Framework;
using SelenuimAdvHomework.DemoQA.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Tests.Interactions.Droppale
{
    [TestFixture]
    public class DroppableElementChangeText : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://www.demoqa.com/droppable");
        }

        [Test]
        public void DropBoxChangeText_WhenDragBoxMoveToBox()
        {
            DroppablePage dropPage = new DroppablePage(Driver);

            Builder
                .MoveToElement(dropPage.dragMeBox)
                .ClickAndHold()
                .DragAndDrop(dropPage.dragMeBox, dropPage.dropHereBox)
                .Perform();

            var textOfDropBox = "Dropped!";

            Assert.AreEqual(textOfDropBox, dropPage.dropBoxInnerText.Text);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
