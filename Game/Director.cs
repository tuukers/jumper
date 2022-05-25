using System;

namespace Jumper
{
  class Director
  {
    //atributes
    private bool isPlaying = true;
    private bool EndGame=false;
    private string secretWord;

    //constructor
    public Director()
    {
      // Get secret word.
      RandomWord Word = new RandomWord();
      this.secretWord = Word.GetSecretWord(); 
    }

    public void GameLoop()
    {
      // Construct gamestate which also constructs blank word.
      GameState gameState = new GameState(secretWord);
      ParaTrooper paraTrooper = new ParaTrooper();
      UserInterface ui = new UserInterface();

      while(isPlaying)
      {
        string[] blank = gameState.blankWord;
        ui.DisplayBlankWord(blank);
        paraTrooper.DisplayParaBoi();
        string guess = ui.ReadLetter();
        bool correct = gameState.checkGuess(guess);

        if(correct)
        {
          gameState.updateBlankWord(guess);
        }
        else
        {
          paraTrooper.mistakeCount++;
        }

        int mistakes = paraTrooper.mistakeCount;
        bool gameOver = gameState.CheckWinLoss(mistakes);

        if(gameOver) 
        {
          isPlaying = false;
        }       
      }
    }
  }  
}    
