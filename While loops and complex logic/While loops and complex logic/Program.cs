using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loops_and_complex_logic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user to think of a number between 0 and 100
            Console.WriteLine("I want you to think of a number between 0 and 100. Ok?");
            Console.ReadLine();

            // Define maximum number the user can guess
            int max = 100;

            // Keep track of the number of guesses
            int guesses = 0;

            // The start guess from
            int guessMin = 0;

            // The start guess to (half of the max)
            int guessMax = max / 2;

            // While the guess isn't the same as the know maximum value
            while (guessMin != max)
            {
                // Increase guess amount (by 1)

                guesses++;

                // Ask the user if their number is between the guess range
                Console.WriteLine($"Is your number between { guessMin } and { guessMax }?");
                string response = Console.ReadLine();

                //bool hasResponse = (response != null && response.Length > 0);
                //if ( hasResponse && (response[0] == 'y' || response[0] == 'Y'))
                //above 2 lines can be converted to one below using Linq

                // if the user confirmed their number is within the current range...
                if (response?.ToLower().FirstOrDefault() == 'y')
                {
                    // We know the number is between guessFrom and guessTo
                    // So set the new maximum number 
                    max = guessMax;

                    // Change the next guess range to be half of the new maximum range
                    guessMax = guessMax - (guessMax - guessMin) / 2;
                }
                // The number is greater than guessMax and less than or equal to max
                else
                {
                    // the new minimum is one above the old maximum
                    guessMin = guessMax + 1;

                    // Guess the bottom half of the new range
                    int remainingDifference = max - guessMax;

                    // Set the guess max to half way between the guessMin and max
                    // NOTE: math.ceiling will round up the remaining difference to 2, if the difference is 3
                    // math.floor is opposite 1.9==1 -- math.ceiling 1.9==2. 
                    guessMax += (int)Math.Ceiling(remainingDifference / 2f);

                }

                // If we only have 2 numbers left, guess one of them
                if(guessMin +1 == max)
                {
                    guesses++;

                    // Ask the user if their number is the lower number
                    Console.WriteLine($"Is your number { guessMin }?");
                    response = Console.ReadLine();

                    // if the user confirmed their number is the lower number...
                    if (response?.ToLower().FirstOrDefault() == 'y')
                    {
                        break;
                    }
                    else
                    {
                        // That means the number must be higher of the two
                        guessMin = max;
                        break;

                    }
                }
            }

            // Tell the user their number
            Console.WriteLine($"Your number is { guessMin } ***");

            // Let the user know how many guesses it took
            Console.WriteLine($" Guessed in { guesses } guesses");

            Console.ReadLine();

        }
    }
}
