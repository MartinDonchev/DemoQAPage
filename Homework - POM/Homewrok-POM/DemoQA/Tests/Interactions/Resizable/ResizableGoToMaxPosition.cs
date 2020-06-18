using NUnit.Framework;
using SelenuimAdvHomework.DemoQA.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Tests.Resizable
{
    [TestFixture]
    public class ResizableGoToMaxPosition : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://www.demoqa.com/resizable");
        }

        [Test]
        public void ResizableGoToMax()
        {
            ResizablePage resizible = new ResizablePage(Driver);

            Builder.DragAndDropToOffset(resizible.resizableArrow, 300, 100).Perform();

            Assert.AreEqual(resizible.container.Size.Width, resizible.resizableBox.Size.Width);
            Assert.AreEqual(resizible.container.Size.Height, resizible.resizableBox.Size.Height);
        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
