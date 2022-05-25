using System;

namespace Jumper
{
    class GameState
    {
        //atributes
        private string mysteryWord;
        public string[] blankWord;

        //constructor
        public GameState(string secretWord)
        {
            this.mysteryWord = secretWord;
            this.blankWord = new string [secretWord.Length];

            for(int i = 0; i < secretWord.Length; i++){
                blankWord[i] = "_";
            }
        }

        //methods
        public bool checkGuess(string guess)
        {
            if(mysteryWord.Contains(guess))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public void updateBlankWord(string guess)
        {
            for(int i=0; i<mysteryWord.Length; i++)
            {
                if(guess == mysteryWord[i].ToString())
                {
                    blankWord[i] = guess;
                }
            }
        }

        public bool CheckWinLoss(int mistakeCount)
        {
            if (String.Concat(blankWord) == mysteryWord)
            {
                Console.WriteLine("Congratulations you landed safely!");
                return true;
            }
            else if (mistakeCount == 4)
            {
                Console.WriteLine("You Lost. Better luck next time.");
                return true;
            }
            else {
                return false;
            }
        }
    }
}