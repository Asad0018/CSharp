﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Print_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a natural number");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("+");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}