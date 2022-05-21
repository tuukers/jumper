using System;

namespace Jumper
{
    class Director
    {
      static void Main(string[] args)
      {
        //atributes
        private bool Playing=true;
        private bool EndGame=false;

        //constructor
        public Director()
        {
          EndGame GameOver = new EndGame();

        }

        public GameLoop()
        {
          while(playing)
          {
            EndGame=GameOver.EndGameCheck();//needs string FoundWord and Bool Wrong(from Checker).
            if(EndGame)
            {
              Playing=false;
            }
          }
        }

      }  
    }    
}