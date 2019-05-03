using System;
using System.Collections.Generic;
using System.Text;

namespace WordCounter.Models
{

    public class Phrase
    {
        private string _userPhrase;
        private string _checkedWord;
        private static List<Phrase> _instances = new List<Phrase> { };

        public Phrase(string sentence, string checkedWord)
        {
            _userPhrase = sentence;
            _checkedWord = checkedWord;
            _instances.Add(this);
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

        public static List<Phrase> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public string toLowerCase(string word)
        {
            word = _userPhrase.ToLower();
            return word;
        }

        public string toUpperCase(string word)
        {
            word = _userPhrase.ToUpper();
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
            List<char> numList = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i =0; i < charSent.Length; i ++)
            {
              if(numList.Contains(charSent[i]))
                {
                    return true;
                }
                
            }
            return false;
            
        }

        public bool HasSym(string sentence)
        {
            char[] charSent = sentence.ToCharArray();
            List<char> symList = new List<char>() { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '~', '-', '_', '+', '=', '{', '}', '[', ']', '<', '>', '?', '.', ',' };
            {
                for(int i =0; i < charSent.Length; i++)
                {
                    if(symList.Contains(charSent[i]))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public int CheckRepeatedWord()
        {
            int wordCount = 0;
            string checkedPhrase = _userPhrase.ToLower();
            string[] words = checkedPhrase.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                if (_checkedWord.Equals(words[i]))
                {
                    wordCount++;
                }
            }
            return wordCount;
        }
    }
}
