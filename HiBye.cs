using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_HiBye
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            if (20 <= age && age <= 30)
                Console.WriteLine("Hi");
            else
                Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
