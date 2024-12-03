using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a natural number");
            int num = int.Parse(Console.ReadLine());
            int fib1 = 0, fib2 = 1;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(fib1 + ", " + fib2 + ", ");
            for (int i = 3; i <= num; i++)
            {
                int fib3 = fib1 + fib2;
                Console.Write(fib3 + ", ");
                fib1 = fib2;
                fib2 = fib3;
            }
            Console.ReadKey();
        }
    }
}
