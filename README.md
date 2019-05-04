#_Epicodus Code Review C# Week 7 Word Counter.Solution_

#### _Build out an MVC web user interface for Word Counter application build at 04/26. The Word Counter is a program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence, 05.03.2019_

#### _By** Sabrina M**_

## Description

_Write a program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence.

## Specifications


| Behavior | Input | Output |
| ------------- |:-------------:| -----:|
| The application ask to the user to input a word and a sentence and return a number of the count of the occurrence of his word. | word = "cat" ; sentence = "I'm walking to the cathedral with my cat"| 1|
| The user inputs a number as a word and as a sentence, the application return the count of the number as a word. | word = "33" ; sentence = "3333333"| 3|
| The user inputs a number and non-alphabetical characters as a word and as a sentence, the application return the count of the number and and recognizes the character and the number as a word. | word = "3" ; sentence = "3333333%$#"| 7|
| The Program count how many times the word appears in the sentence but it should check for full word matches only.| word = "CAT" ; sentence = "I'm walking to the CAThedral." |  0 |
| The application manages all uppercase and mixed case entries | word = "cAt" ; sentence = "I'm walking to the cathedral with my white CAT, my black Cat and my grey cAt!!"| 3|
| The user inputs a empty word and/or sentence, the application returns an alert and the program stops (break). | word = " " ; sentence = " "| "Please don't try to break my code :)"|



* 1/Simplest Behavior : Ask to the user a word and a sentence
  * a/ Declaration of RepeatCounter class
  * b/ Give to the class two Properties, a word and a sentence
  * c/ Declare a constructor that takes a word and a sentence as a parameter
* 2/ Simplest Behavior : Check if the word from the user appears in the sentence
  * d/ Create method to get private property word and sentence from the constructor
  * e/ Create Boolean Method to check if a word appears in a sentence, true if the method find the word in the sentence otherwise false
* 3/ Simplest Behavior : Check how frequently the word appears in the sentence and the application should check for full word matches only
  * f/ Create an Integer Method with a while loop to get the number of occurrence in a sentence
  * g/ When the application find the word in the sentence, add the value of the position to a int variable + the value of the length of the word, this allows to look for a new occurrence after this word
* 4/ Simplest Behavior : Find a word in the sentence even if the case is different
  * h/ Add the ToLower method in CheckNumberOccurence Method to manage mixed case entries of the sentence and word
* 5/ Simplest Behavior : Return a sentence and stop the program if the user doesn't fill the fields
  * i/ Add a if and the IsNullOrEmpty in Method to the while loop to avoid an infinite loop and stop the program
* 6/ Simplest Behavior : Run the program in the Console
  * j/ Create a Program file to ask to the user for a word and a sentence




## Setup/Installation Requirements

*_Download .NET Core 2.2.103 SDK install it. Download Mono and install it.
*_Link of my repo : https://github.com/sabrinamianne/WordCounter.Solution.git
*_Clone this repository: git clone repo name_
*_Change into the work directory:: $ cd WordCounter.Solution
*_To edit the project, open the project in your preferred text editor.
*_To run the program, first navigate to the location of the WordCounter.cs file then compile and execute: $cd WordCounter/Models $ mcs Program.cs RepeatCounter.cs; mono Program.exe;
*_To run the tests, use these commands: $ cd WordCounter.Tests $ dotnet test


## Known Bugs

_ No Bug but no User Interface until 05/03/2019_

## Support and contact details

_Contact me by e-mail at the following address : sabrina.epicodus@gmail.com_

## Technologies Used

_C#_
_.NET Core App 2.2.103 & ASP.NET Core Mono Atom Git Github_


### License

*This software is licenced under the MIT licence*

**_Copyright (c) 2019 Sabrina M_**
