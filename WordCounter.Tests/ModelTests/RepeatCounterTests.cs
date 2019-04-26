using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

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
            bool resultCheckBool = Check.CheckBoolOccurence (userSentence,userWord);
            bool resultCheckBool2 = Check.CheckBoolOccurence (userSentence,word2);
            //Assert
            Assert.AreEqual(true, resultCheckBool);
            Assert.AreEqual(false, resultCheckBool2);
          
            
        }

    }
}