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
            Phrase newPhrase = new Phrase("test");
            Assert.AreEqual(typeof(Phrase), newPhrase.GetType());
        }

        [TestMethod]
        public void GetPhrase_ReturnsPhrase_String()
        {
            string phrase = "word word word";
            Phrase newPhrase = new Phrase(phrase);
            string result = newPhrase.GetPhrase();
            Assert.AreEqual(result, phrase);
        }

        [TestMethod]
        public void SetPhrase_SetsThePhrase_String()
        {
            string userPhrase = "word word word";
            Phrase newPhrase = new Phrase(userPhrase);

            string updatedPhrase = "another phrase";
            newPhrase.SetString(updatedPhrase);
            string result = newPhrase.GetPhrase();

            Assert.AreEqual(updatedPhrase, result);
        }

        [TestMethod]

        public void CheckWordNum_CheckTimesWordIsCaught_Int()
        {
            string userPhrase = "word word word";
            Phrase newPhrase = new Phrase(userPhrase);

            string checkedString = newPhrase.GetPhrase();
            int wordCount =newPhrase.CheckRepeatedWord(checkedString);

            Assert.AreEqual(3, wordCount);
        }
    }
}
