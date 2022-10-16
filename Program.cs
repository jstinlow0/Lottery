/*Author: Justin Lo
 * Date: Sep 19, 2021
 * Description: Generates three random numbers, each between 1 and 4. Allows the user to guess three numbers. Compare each of the user’s guesses to the three random numbers,
 * and displays a message that includes the user’s guess, the randomly determined three-digit number, and the amount of money the user has won.
 */
using System;
using static System.Console;

namespace Lotttery
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring varable
            int matches = 0;

            //Generates 3 random number from 1 - 4.
            Random ranNumGenerator = new Random();

            int ranNum1 = ranNumGenerator.Next(1, 5);
            int ranNum2 = ranNumGenerator.Next(1, 5);
            int ranNum3 = ranNumGenerator.Next(1, 5);

          
            //takes in users guesses
            WriteLine("Take a guess, Any Guess, Three Guessses between 1 - 4! >> ");
            Write("First Guess:");
            int g1 = int.Parse(ReadLine());
            Write("Second Guess:");
            int g2 = int.Parse(ReadLine());
            Write("Third Guess:");
            int g3 = int.Parse(ReadLine());

            WriteLine("\nThe Random Generated Numbers were: {0}, {1}, and {2}.\n", ranNum1, ranNum2, ranNum3);
            WriteLine("You've guessed numbers: {0}, {1}, and {2}.\n", g1, g2, g3);

            //Compares guessed # with random generated # and determines how much user gets awards with and how many matching # user got based on how many "matches" the user got.
            if (g1 == ranNum1 && g2 == ranNum2 && g3 == ranNum3)
            {
                ++matches;
            }
            if (g1 == ranNum1 || g1 == ranNum2 || g1 == ranNum3 && g1 != g2 && g1 != g3)
            {
                ++matches;
            }
            if (g2 == ranNum1 || g2 == ranNum2 || g2 == ranNum3 && g2 != g1 && g2 != g3)
            {
                ++matches;
            }
            if (g3 == ranNum1 || g3 == ranNum2 || g3 == ranNum3 && g3 != g2 && g3 != g1)
            {
                ++matches;
            }
            if (matches == 1)
                WriteLine("Congrats! You have one digit matching - you WIN $10!");
                if (matches == 2)
                    WriteLine("Congrats! You have two digits matching - you WIN $100.");
                    if (matches == 3)
                        WriteLine("Congrats! You have three digits matching but not in order - you WIN $1,000.");
                        if (matches == 4)
                            WriteLine("Congrats! You have all three digits in matching order! You WIN $10,000!.");
            if (matches == 0)
                WriteLine("You have no matches, Better Luck Next Time :(");
          
        }
    }
}
