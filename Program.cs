using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//       +---------------------------------------------+
//       | بررسی می‌کند که آیا عدد ورودی اول است یا خیر          |
//       +---------------------------------------------+
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
                if (num % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    break;
                }
                else
                {
                    Console.WriteLine("It's Prime");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
