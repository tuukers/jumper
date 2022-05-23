using System;

namespace Jumper
{
    class RandomWord
    {

        // Attributes
        // list of randoms word
        private string secretWord;
        private string[] wordList = new string["pizza", "lasagna", "fettuccine", "breadstick"]; 


        // Constructor
        public RandomWord()
        {
            secretWord = GetNewWord();
        }

        private string GetNewWord() 
        {
            Random random = new Random();
            
            num = random.Next(1,wordList.Length);

            string word = wordList[num];

            return word;
        }

        public string GetSecretWord() {
            return secretWord;
        }

    }   
}