using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizzard cWizzard = new Wizzard();
            cWizzard.Age = 300;

            Console.WriteLine(cWizzard.Age);
            Console.Read();

        }
    }
}
