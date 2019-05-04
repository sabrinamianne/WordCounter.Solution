using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _word;
        private string _sentence;
        private int _countOccurence;
        private int _indexOccur;
        private string _errorMessage="";
        

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

        public int GetCount()
        {
          return _countOccurence;
        }
        public string GetEmptyMessage()
        {
          return _errorMessage;
        }


        public bool CheckBoolOccurence (string word, string sentence)
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

        public bool CheckEmpty(string _word, string _sentence)
        {
          if (string.IsNullOrEmpty(_sentence)&& string.IsNullOrEmpty(_word))
          {
            _errorMessage="Please, enter a sentence and a word to play!";
            return true;
          }
          else if (string.IsNullOrEmpty(_sentence))
            {
              _errorMessage = "Please, enter a sentence.";
              return true;
            }
          else if (string.IsNullOrEmpty(_word))
            {
              _errorMessage = "Please, enter a word!";
              return true;
            }
          else
          {
            return false;
          }
        }

        public int CheckNumberOccurence(string _word, string _sentence)
        {
            _countOccurence = 0;
            _indexOccur = 0;
            _word = _word.ToLower();
            _sentence = _sentence.ToLower();
            while ((_indexOccur = _sentence.IndexOf(_word,_indexOccur)) != -1)
            {
                _indexOccur += _word.Length;
                _countOccurence += 1;
            }
            _errorMessage ="";
            return _countOccurence;
        }

    }
}
