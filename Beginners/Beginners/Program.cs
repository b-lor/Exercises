using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners
{
    class Program
    {
        // 3. Accessibility levels
        private static byte myPrivate;     //Acessicble only within Program (this class)
        protected static byte myProtected; // Only accessible this class and ay class that overrrides us
        public static byte myPublic;       // No access restrictions

        // 4. Different ways to declare variables (numbers vs properties)
        private static byte mMyVariable;
        private static string mCreditCardNumber;

        public static byte MyVariable { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 10...");
            string userResponse = Console.ReadLine();

            int userNumber;
            if (int.TryParse(userResponse, out userNumber))
            {
                if (userNumber < 1 || userNumber > 10)
                {
                    Console.WriteLine("Sorry, the number was outside of the range");
                }
                else
                {
                    //userNumber = userNumber * 2; 
                    //short hand number below and above
                    userNumber *= 2;

                    // 8. Constructing strings from variables
                    Console.WriteLine("Your new number is " + userNumber);
                    //Console.WriteLine("$Your new number is {usernumber}. Which is 2 times the value"); new and better way 

                }
            }
            else
            {
                Console.WriteLine("Sorry, that was not a recognized number");
            }
            Console.WriteLine("Press enter to close");
            Console.ReadLine();

        }
    }
}
