using System;
using WordCounter.Models;

namespace WordCounter
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome, please enter a sentence and a word to check the occurence of your word in your sentence.");
            Console.WriteLine("Enter a sentence: ");
            string userInputSentence = Console.ReadLine();
            Console.WriteLine("Enter a word: ");
            string userInputWord = Console.ReadLine();
            RepeatCounter newUserInput = new RepeatCounter(userInputWord, userInputSentence);
            string userWord = newUserInput.GetUserWord();
            string userSentence= newUserInput.GetUserSentence();
            int resultCheckCount = Check.CheckNumberOccurence (userSentence,userWord);
            Console.WriteLine("Your word appears " +resultCheckCount+ " times in your sentence." );
        }
    }
}