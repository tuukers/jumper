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
        public void ReadLetter(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        // Display given text on UI 
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
    }
} 
