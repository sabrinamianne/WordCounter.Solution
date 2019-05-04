using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCountersControllerTest
    {
      [TestMethod]
      public void CreateForm_ReturnsCorrectView_True()
      {
        //Arrange
       WordCountersController controller = new WordCountersController();

        //Act
        ActionResult indexView = controller.CreateForm();

        //Assert
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }

      [TestMethod]
      public void Create_ReturnsCorrectActionType_RedirectToActionResult()
      {
          //Arrange
           WordCountersController controller = new  WordCountersController();

          //Act
          IActionResult view = controller.Create("alive","I am alive");

          //Assert
          Assert.IsInstanceOfType(view, typeof(ViewResult));
      }
    }
}
