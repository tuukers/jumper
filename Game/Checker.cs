// using System;

// namespace Jumper
// {
//     // Check if guessed letter matches any letters in random word
//     // Needs to return a wrong bool for CheckLoss in EndGame Class.
//     public class Checker
//     {
//         // Attributes
//         private int currentIndex = 0;
//         private int[] indexList;

//         public Checker()
//         {
//         }

//         // Return true/false if guess is right or wrong
//         public bool checkGuess(string guess, string[] word)
//         {
//             int check = Array.IndexOf(word, guess);
//             if (check == -1)
//             {
//                 return false;
//             }
//             else
//             {
//                 return true;
//             }
//         }

//         // Return all indexes for each character in word that matches guess
//         public void fetchLocations(string guess, string[] word)
//         {
//             foreach (letter in word)
//             {
//                 if (letter == guess)
//                 {
//                     indexList.Add(currentIndex);
//                 }
//                 currentIndex++;
//             }
//         }

//     }
// }