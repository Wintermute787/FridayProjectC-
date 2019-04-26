using System;
using System.Collections.Generic;
using System.Text;

namespace WordCounter.Models
{

    public class Phrase
    {
        private string _userPhrase;

        public Phrase(string sentence)
        {
            _userPhrase = sentence;
        }

        public string GetPhrase()
        {
            return _userPhrase;
        }

        public void SetString(string newPhrase)
        {
            _userPhrase = newPhrase;
        }

        public int CheckRepeatedWord(string userWord)
        {
            int wordCount = 0;
            string checkedPhrase = _userPhrase.ToLower();
            string[] words = checkedPhrase.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (userWord == words[i])
                {
                    wordCount++;
                }

            }
            return wordCount;
        }
    }
}
