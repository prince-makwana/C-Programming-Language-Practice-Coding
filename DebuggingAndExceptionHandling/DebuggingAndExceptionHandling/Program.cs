using System;

namespace DebuggingAndExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number1;
            //number1 = 10;

            //string name = "John Smith";
            //PrintMessage("This is the debugging demo app.");
            //Console.ReadLine();

            //Exception Handling

            try
            {
                int number = 10;
                int result = number / 0;

                int[] numbers = new int[3] { 4, 5, 8 };
                Console.WriteLine(numbers[3]);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Index out of boundary of Array");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch(DivideByZeroException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You cannot divide an integer by ZERO");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An exception occured in app: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
                //Windows Events, log to file.
            }
            finally
            {
                Console.WriteLine("This is finally block");
            }
            Console.WriteLine("Hello World!!!");
        }

        static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
