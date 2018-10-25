using Classes_Functions_and_Regions;
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

            // 1. Creating Classes

            // 2. Regions

            // 3. Creating Functions

            // 4. Using classes

            // Create a new instance of our number guesser class
            var numberGuesser = new NumberGuesser();

            // Change the default maximum number to 200
            numberGuesser.MaximumNumber = 200;

            // Ask the user to think of a number
            numberGuesser.InformUser();

            // Discover the number the user is thinking of
            numberGuesser.DiscoverNumber();

            // Announce the results
            numberGuesser.AnnounceResults();



        }
    }
}
