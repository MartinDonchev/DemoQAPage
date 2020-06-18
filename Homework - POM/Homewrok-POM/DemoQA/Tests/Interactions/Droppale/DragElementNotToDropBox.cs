using NUnit.Framework;
using SelenuimAdvHomework.DemoQA.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Tests.Interactions.Droppale
{
    [TestFixture]
    public class DragElementNotToDropBox : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://www.demoqa.com/droppable");
        }

        [Test]
        public void DropBoxTextDontChange_WhenDragBoxIsNotMoveToBox()
        {
            DroppablePage dropPage = new DroppablePage(Driver);

            Builder
               .MoveToElement(dropPage.dragMeBox)
               .ClickAndHold()
               .DragAndDropToOffset(dropPage.dragMeBox, 0, 100)
               .Perform();

            var textOfDropBox = "Drop here";

            Assert.AreEqual(textOfDropBox, dropPage.dropHereBox.Text);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
