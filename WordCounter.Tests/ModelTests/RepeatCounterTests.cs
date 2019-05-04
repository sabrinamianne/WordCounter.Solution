using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTests
    {

        [TestMethod]
        public void RepeatCounterConstructor_CreatesInstanceOfRepeatCounter_RepeatCounter()
        {
            string word = "car";
            string sentence = "I need to buy a new car.";
            RepeatCounter newWordCounter = new RepeatCounter(word,sentence);
            Assert.AreEqual(typeof(RepeatCounter), newWordCounter.GetType());
        }

        [TestMethod]
        public void GetUserWordAndSentence_GetWordAndSentenceFromUser_String()
        {
            //Arrange
            string word = "car";
            string sentence = "I need to buy a new car.";
            RepeatCounter userInput = new RepeatCounter(word,sentence);
            //Act
            string userWord = userInput.GetUserWord();
            string userSentence= userInput.GetUserSentence();
            //Assert
            Assert.AreEqual(word, userWord);
            Assert.AreEqual(sentence, userSentence);

        }

        [TestMethod]
        public void CheckOccurence_GetCheckForOccurrence_True()
        {
            //Arrange
            string word = "car";
            string word2 ="card";
            string sentence = "I need to buy a new car.";
            RepeatCounter userInput = new RepeatCounter(word,sentence);
            //Act
            string userWord = userInput.GetUserWord();
            string userSentence= userInput.GetUserSentence();
            bool resultCheckBool = userInput.CheckBoolOccurence (userWord, userSentence);
            bool resultCheckBool2 = userInput.CheckBoolOccurence (word2, userSentence);
            //Assert
            Assert.AreEqual(true, resultCheckBool);
            Assert.AreEqual(false, resultCheckBool2);
        }

        [TestMethod]
        public void CheckNumberOccurence_GetCountForOccurrence_Int()
        {
            //Arrange
            string word = "car";
            string word2 ="card";
            string wordUpperCase = "CAR";
            string sentence = "I need to buy a new car, a blue car.";
            RepeatCounter userInput = new RepeatCounter(word,sentence);
            //Act
            string userWord = userInput.GetUserWord();
            string userSentence= userInput.GetUserSentence();
            int resultCheckCount = userInput.CheckNumberOccurence (userWord, userSentence);
            int resultCheckCount2 = userInput.CheckNumberOccurence(word2,userSentence);
            int resultCheckCountUpperCase = userInput.CheckNumberOccurence(wordUpperCase,userSentence);
            //Assert
            Assert.AreEqual(2, resultCheckCount);
            Assert.AreEqual(0, resultCheckCount2);
            Assert.AreEqual(2, resultCheckCountUpperCase);
        }
    }
}
