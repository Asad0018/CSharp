using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a natural number");
            int num = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;

            for (int j = 1; j <= num; j++)
            {
                Console.WriteLine();
                for (int i = 1; i <= num; i++)
                    Console.Write(i*j + ",");
            }
            Console.ReadKey();
        }
    }
}
