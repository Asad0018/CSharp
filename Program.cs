using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BMM
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
            long bmm = nums[0];

            Console.ForegroundColor = ConsoleColor.Yellow;
            while (true)
            {
                if (nums[1] % bmm == 0 && nums[0] % bmm == 0)
                {
                    Console.WriteLine("BMM: " + bmm);
                    break;
                }
                bmm--;
            }
            Console.ReadKey();
        }
    }
}