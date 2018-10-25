using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions___methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            Console.Write("Enter first number\t\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number\t\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Program eOne = new Program();
            int add=eOne.sum(num1, num2);
            Console.WriteLine("Addition\t\t{0}", add);

            Program.sum();
            Console.ReadKey();

        }
        public int sum(int no1, int no2)
        {
            //int no1 = 365, no2 = 234;
          
            int add = no1 + no2;
            return add;
            //Console.WriteLine("Addition\t\t{0}", add);
        }
    }
}
