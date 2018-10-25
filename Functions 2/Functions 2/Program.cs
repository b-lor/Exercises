using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int num=0;
            do
            {
                menu();

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    num = inputVal();
                }
            } while (num != 0);
        }
        public static void menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("");
            Console.WriteLine("1: Input a number");
            Console.WriteLine("2: Output number");
        }
        public static int inputVal()
        {
            int enterNum = 0;
            Console.WriteLine("Enter a number");
            enterNum = int.Parse(Console.ReadLine());

            return enterNum;
        }

    }
}
