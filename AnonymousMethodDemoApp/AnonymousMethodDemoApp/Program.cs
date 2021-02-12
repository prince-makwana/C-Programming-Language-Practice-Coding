using System;

namespace AnonymousMethodDemoApp
{
    //Anonymous Method - is a way to create a method inline without a name. And it can be referred to a delegate.
    //So, in scenarious where we have methods which accepts delegate type parameter, we don't have to create a
    //separate method. We can work with anonymous method.

    delegate void PrintDelegate(string param);
    class Program
    {
        static void Main(string[] args)
        {
            //PrintDelegate del = PrintInformation;
            //LogAndPrintInformation(del);

            //Anonymous Method Syntax: delegate (params) { }
            LogAndPrintInformation(delegate (string parameter)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"PrintInformation with parameter: {parameter} ");
                Console.ForegroundColor = ConsoleColor.White;
            });
        }

        static void LogAndPrintInformation(PrintDelegate print)
        {
            print("This is Anonymous Method demo app.");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Logging to console window. \n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //static void PrintInformation(string parameter)
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine($"PrintInformation with parameter: {parameter} ");
        //    Console.ForegroundColor = ConsoleColor.White;
        //}
    }
}
