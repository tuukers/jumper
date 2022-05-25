using System;

namespace Jumper
{
    class RandomWord
    {

        // Attributes
        // list of randoms word
        private string secretWord;
        private string[] wordList = {"pizza", "lasagna", "fettuccine", "breadstick"}; 


        // Constructor
        public RandomWord()
        {
            secretWord = NewWord();
        }

        private string NewWord() 
        {
            Random random = new Random();
            
            int num = random.Next(0,wordList.Length);

            string word = wordList[num];

            return word;
        }

        public string GetSecretWord() {
            return secretWord;
        }

    }   
}