using System;

namespace Jumper
{
  class Director
  {
    //atributes
    private bool EndGame=false;
    private string secretWord;

    //constructor
    public Director()
    {
      RandomWord Word = new RandomWord();
      this.secretWord = Word.GetSecretWord();
      Checker Checker = new Checker();
      ParaTrooper paraTrooper = new ParaTrooper();
      UserInterface UI = new UserInterface();
      GameState GameOver = new GameState(this.secretWord);
    }

    public void GameLoop()
    {
      while(playing)
      {
        
        EndGame = GameOver.EndGameCheck();//needs string FoundWord and Bool Wrong(from Checker).
      }
    }
  }  
}    
