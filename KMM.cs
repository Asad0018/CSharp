using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_KMM
{
    class Program
    {
        static long Get()
        {
            Console.WriteLine("Enter a number");
            return long.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            long[] nums = { Get(), Get() };
            long kmm = nums[0];

            Console.ForegroundColor = ConsoleColor.Cyan;
            while (true)
            {
                if (kmm % nums[1] == 0 && kmm % nums[0] == 0)
                {
                    Console.WriteLine("KMM: " + kmm);
                    break;
                }
                kmm++;
            }
            Console.ReadKey();
        }
    }
}
