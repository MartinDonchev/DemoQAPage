using NUnit.Framework;
using SelenuimAdvHomework.DemoQA.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.DemoQA.Tests.Resizable
{
    [TestFixture]
    public class ResizableGoToMinPosition : BaseTest
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

            Builder.DragAndDropToOffset(resizible.resizableArrow, -50, -50).Perform();

            Assert.AreEqual(150, resizible.resizableBox.Size.Width);
            Assert.AreEqual(150, resizible.resizableBox.Size.Height);
        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
