using System;

namespace Jumper
{
    // Handler for terminal operations.
    // Provide input and output operations for the user interface.
    public class UserInterface
    {
        public UserInterface()
        {
        }

        // Direct user with given prompt and get one letter string

        public void DisplayBlankWord(string[] blankWord) 
        {
            for(int i = 0; i < blankWord.Length; i++)
            {
                Console.Write(blankWord[i]);
            }
        }

        public string ReadLetter()
        {
            Console.Write("Guess a letter [a-z]: ");
            string input = Console.ReadLine();
            return input;
        }
    }
} 
