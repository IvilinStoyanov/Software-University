﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03.Printing_Triangle
{
    class Program
    {      
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintTriangles(int n)
        {
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }
            for (int line = n-1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }

        static void Main(string[] args)
        {
            PrintTriangles(n: int.Parse(Console.ReadLine()));
        }


    }
}
