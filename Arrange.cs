using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//         +-------------------------------------------------------------------+
//         |   سه عدد دریافت می‌کند و آنها را از بزرگ به کوچک مرتب می‌کند                   |
//         +-------------------------------------------------------------------+
namespace _03_Arrange
{
    class Program
    {
        static double Get()
        {
            Console.WriteLine("Enter a number");
            return double.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            double[] nums = { Get(), Get(), Get() };
            Array.Sort(nums);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sorted Numbers from large to small:");
            for (int i = nums.Length; i > 0; i--) Console.Write(nums[i - 1] + " , ");
            Console.ReadKey();
        }
    }
}
