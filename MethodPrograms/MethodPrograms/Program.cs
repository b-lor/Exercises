using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //we are going to ask a method to return some type of value
            //an addition program that returns values
            //send in 2 values, or just receive
            int firstDigit = 0, secondDigit = 0, finalAnswer;

            Console.WriteLine("Enter in your first digit");
            firstDigit = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter in your second digit");
            secondDigit = int.Parse(Console.ReadLine());

            finalAnswer = addMe(firstDigit, secondDigit);
            Console.WriteLine(finalAnswer.ToString());
            helloName("Bill");

            Console.ReadLine();

        }
        static private int addMe(int nbrOne, int nbrTwo)
        {
            int tempVaule;
            tempVaule = nbrOne + nbrTwo;
            return tempVaule;
        }
        static private void helloName(string name)
        {
            Console.WriteLine("Hello " + name);

        }

    }
}
