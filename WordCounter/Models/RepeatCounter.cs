using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _word;
        private string _sentence;

        public RepeatCounter (string word, string sentence)
        {
            _word = word;
            _sentence = sentence;
        }

        public string GetUserWord()
        {
            return _word;
        }

         public string GetUserSentence()
        {
            return _sentence;
        }
    }
    public static class Check
    {
        public static bool CheckBoolOccurence (string sentence, string word)
        {
            if (sentence.IndexOf(word) != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int CheckNumberOccurence(string sentence, string word)
        {
            int countOccurence = 0;
            int indexOccur = 0;
             word = word.ToLower();
             sentence = sentence.ToLower();
            while ((indexOccur = sentence.IndexOf(word,indexOccur)) != -1)
            {
                if (string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(word) )
                {
                    Console.WriteLine("Please don't try to break my code :)");
                    break;
                }
                else
                {
                indexOccur += word.Length;
                countOccurence += 1;
                }
            }
                return countOccurence;   
                    
        }
    }
}