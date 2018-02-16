using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DayFinder.Controllers;
using DayFinder.Models;

namespace DayFinder.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            ViewResult indexView = new HomeController().Index() as ViewResult;

            //Act
            ViewResult result = indexView as ViewResult;

            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}
