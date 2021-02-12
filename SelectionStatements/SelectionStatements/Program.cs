using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;

            int a = 2;
            int b = 46;

            if (flag == true)
            {
                Console.WriteLine("This is the if lock body");
            }
            else if ((a == b) || (a > b)) //&& -- AND, || -- OR, >, >=, <, <=, !
            {
                Console.WriteLine("This is else if block");
            }
            else
            {
                Console.WriteLine("This is else block");
            }

            //Switch-Case

            Console.WriteLine("What is your state");
            string state = (Console.ReadLine()).ToUpper();

            switch (state)
            {
                case "TX":
                    Console.WriteLine("Your state is Income Tax Free");
                    break;
                case "CA":
                    Console.WriteLine("Your state have high Income Tax");
                    break;
                default:
                    Console.WriteLine("Invalid Entry!");
                    break;
            }
        }
    }
}
