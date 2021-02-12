﻿using System;

namespace IterationJumpStatementsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Printing i as {i}");
            //}
            //Console.WriteLine();
            //for (int i = 5; i > 0; i--)
            //{
            //    Console.WriteLine($"Printing i");
            //}

            int length = 5;
            for (int i = 0; i < length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Printing i as {i}");
                for (int j = i+1; j < length; j++)
                {
                    if(j == 2)
                    {
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\tPrinting j as {j}");
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();

            int n = 0;
            while (n < 10)
            {
                Console.WriteLine($"Printing i {n} in while loop");
                n++;
            }

            Start:
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine();

            do
            {
                Console.WriteLine("This will execute at least once");
            } while (false);


            //foreach (var item in collection)
            //{

            //}

            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("Do you want to start again?");
            string yesOrNo = Console.ReadLine();
            if (yesOrNo == "Yes")
            {
                goto Start;
            }
        }
    }
}
