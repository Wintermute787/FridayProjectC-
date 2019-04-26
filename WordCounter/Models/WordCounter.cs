using System;
using System.Collections.Generic;
using System.Text;

namespace WordCounter.Models
{

    public class Phrase
    {
        private string _userPhrase;
        private string _checkedWord;

        public Phrase(string sentence, string checkedWord)
        {
            _userPhrase = sentence;
            _checkedWord = checkedWord;
        }

        public string GetPhrase()
        {
            return _userPhrase;
        }

        public string GetWord()
        {
            return _checkedWord;
        }

        public void SetString(string newPhrase)
        {
            _userPhrase = newPhrase;
        }

        public void SetWord(string newWord)
        {
            _checkedWord = newWord;
        }

        public string toLowerCase(string word)
        {
            word = _userPhrase.ToLower();
            return word;
        }

        public bool HasSpace(string sentence)
        {
            if(sentence.Contains(" "))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNum(string sentence)
        {
            char[] charSent = sentence.ToCharArray();
            List<int> numList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            for(int i =0; i < charSent.Length -1; i++)
            {
                if (charSent[i] == numList[i])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public int CheckRepeatedWord(string userPhrase, string checkedWord)
        {
            int wordCount = 0;
            string checkedPhrase = userPhrase.ToLower();
            string[] words = checkedPhrase.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                if (checkedWord.Equals(words[i]))
                {
                    wordCount++;
                }
            }
            return wordCount;
        }
    }
}
