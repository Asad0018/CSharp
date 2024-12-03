using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Average
{
    class Program
    {
        static void Main(string[] args)
        {
//          +-----------------------------+       
//          |          Variables          |
//          +-----------------------------+
            double num1;
            double num2;
            double num3;

//          +-----------------------------+       
//          |           Inputs            |
//          +-----------------------------+
            Console.WriteLine("Enter a number");
            string a = Console.ReadLine();
            num1 = double.Parse(a);

            Console.WriteLine("Now enter an other");
            string b = Console.ReadLine();
            num2 = double.Parse(b);

            Console.WriteLine("And an other one");
            string c = Console.ReadLine();
            num3 = double.Parse(c);

//          +-----------------------------+       
//          |           Output            |
//          +-----------------------------+
            double Average = (num1 + num2 + num3) / 3;
            Console.WriteLine(Average);

//       ---End-----------------------------       
            Console.ReadKey();

        }
    }
}
