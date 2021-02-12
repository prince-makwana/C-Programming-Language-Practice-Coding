using System;

namespace TypesAnd_VariablesDemo
{
    public struct Customer
    {
        public int age;
        public string name;
        public bool isEmployee;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int age = 35;
            //string name = "John Smith";
            //bool isEmployee = true;
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine(name + " is " + age + " years old.");
            //Console.WriteLine("Is he an employee? " + (isEmployee ? "Yes" : "No"));
            //Console.ForegroundColor = ConsoleColor.White;

            Customer cust;
            cust.age = 35;
            cust.name = "John Smith";
            cust.isEmployee = false;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(cust.name + " is " + cust.age + " years old.");
            Console.WriteLine("Is he an employee? " + (cust.isEmployee ? "Yes" : "No"));
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
