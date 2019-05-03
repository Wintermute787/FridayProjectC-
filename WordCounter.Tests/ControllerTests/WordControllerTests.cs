using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordControllerTest
    {
        [TestMethod]
        public void Index_HasCorrectModelType_WordList()
        {
            //Arrange
            string userPhrase = "word word";
            string userWord = "word";
            Phrase newPhrase = new Phrase(userPhrase, userWord);
            ViewResult indexView = new WordController().Index(newPhrase) as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(Phrase));    
        }

        [TestMethod]
        public void Create_RedirectsToCorrectAction_Index()
        {
            //Arrange
            WordController controller = new WordController();
            RedirectToActionResult actionResult = controller.Create("Test Method", "Test Method again") as RedirectToActionResult;

            //Act
            var result = actionResult.ActionName;

            //Assert
            Assert.AreEqual(result, "Index");

        }
    }
}