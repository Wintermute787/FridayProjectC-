using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void PhraseConstructor_CreatesInstancesOfPhrase_Phrase()
        {
            Phrase newPhrase = new Phrase("test", "test");
            Assert.AreEqual(typeof(Phrase), newPhrase.GetType());
        }

        [TestMethod]
        public void GetPhrase_ReturnsPhrase_String()
        {
            string phrase = "word word word";
            string checkedWord = "word";
            Phrase newPhrase = new Phrase(phrase, checkedWord);
            string result = newPhrase.GetPhrase();
            string resultWord = newPhrase.GetWord();
            Assert.AreEqual(result, phrase);
            Assert.AreEqual(resultWord, checkedWord);
        }

        [TestMethod]
        public void SetPhrase_SetsThePhrase_String()
        {
            string userPhrase = "word word word";
            string checkedWord = "word";
            Phrase newPhrase = new Phrase(userPhrase, checkedWord);


            string updatedPhrase = "another phrase";
            string updatedWord = "another word";
            newPhrase.SetString(updatedPhrase);
            newPhrase.SetWord(updatedWord);
            string result = newPhrase.GetPhrase();
            string resultWord = newPhrase.GetWord();

            Assert.AreEqual(updatedPhrase, result);
            Assert.AreEqual(updatedWord, resultWord);
        }

        [TestMethod]

        public void CheckWordNum_CheckTimesWordIsCaught_Int()
        {
            string userPhrase = "word word word";
            string userWord = "word";
            Phrase newPhrase = new Phrase(userPhrase , userWord);

            string checkedString = newPhrase.GetPhrase();
            string checkedWord = newPhrase.GetWord();
            int wordCount =newPhrase.CheckRepeatedWord(checkedString, checkedWord);

            Assert.AreEqual(3, wordCount);
        }

        [TestMethod]

        public void CheckSpaceBool_ChecksIfSentHasSpace_True()
        {
            string userPhrase = "word word word";
            string userWord = "word";
            Phrase newPhrase = new Phrase(userPhrase, userWord);

            string checkedPhrase = newPhrase.GetPhrase();
            bool result = newPhrase.HasSpace(checkedPhrase);

            Assert.AreEqual(true, result);
        }
    }
}
