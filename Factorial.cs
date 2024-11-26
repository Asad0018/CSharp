using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//          +------------------------------------------------+       
//          |           فاکتوریل عدد ورودی را محاسبه می‌کند           |
//          +------------------------------------------------+
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a natural number");
            int num = int.Parse(Console.ReadLine());
            int fac = 1;
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 1; i <= num; i++)
                fac = fac * i;
            Console.WriteLine("Factorial = " + fac);
            Console.ReadKey();
        }
    }
}
