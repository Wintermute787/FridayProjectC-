using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;


namespace WordCounter.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            WordController controller = new WordController();
            string userPhrase = "word word";
            string userWord = "word";
            Phrase newPhrase = new Phrase(userPhrase, userWord);

            //Act
            ActionResult indexView = controller.Index(newPhrase);

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }
    }
}