using System;

namespace Jumper
{
  class Director
  {
    //atributes
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
      }
    }
  }  
}    
