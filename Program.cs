using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("Enter a natural number");
            string a = Console.ReadLine();
            num = double.Parse(a);
            
            if( num < 1 )          
                Console.WriteLine("!! NATURAL Number Please !!");
            else if( num%2 == 0)
                Console.WriteLine(num*2);
            else if ( num%2 == 1)
                Console.WriteLine(num/2);
            else
                Console.WriteLine("!! NATURAL Number Please !!");


            Console.ReadKey();
        }
    }
}
