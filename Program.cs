using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a natural number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; true; i++)
            {
                if (num == i)
                {
                    Console.Write("It's Prime");
                    break;
                }
                if (num < i || num % i == 0)
                {
                    Console.Write("Not Prime");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
