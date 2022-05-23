using System;

namespace Jumper
{
    class EndGame
    {
        //atributes
        private string MisteryWord;
        private string FoundWord;
        private int MistakeCount = 0;
        private bool EndGame=false;

        //constructor
        public EndGame(string RandomWord)
        {
            this.MisteryWord = RandomWord;
        }

        //methods
        private string GetFoundWord(string FoundWord1)
        {
            FoundWord = FoundWord1;
            return FoundWord;
        }

        public bool CheckWin(string FoundWord1)
        {
            this.FoundWord=GetFoundWord(FoundWord1);
            if (this.FoundWord == this.MisteryWord)
            {
                Console.WriteLine("Congradulations you landed safley!");
                EndGame = true;
                return EndGame;
            }
            else
            {
                return EndGame;
            }
        }

        public bool Checkloss(bool Wrong)
        {
            if(worng)
            {
                MistakeCount+=1;
            }

            if (MistakeCount==5)
            {
                Console.WriteLine("You Lost. Better luck next time.");
                EndGame = true;
                return EndGame;
            }
            else
            {
                return EndGame;
            }
        }

        public bool EndGameCheck(String FoundWord1,bool wrong)
        {
            this.FoundWord=GetFoundWord(FoundWord1);
            this.EndGame=CheckWin(this.FoundWord);
            if(this.EndGame=False)
            {
                this.EndGame=CheckLoss(wrong);
            }
            return this.EndGame;
        }
    }
}