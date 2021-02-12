using System;

namespace PassingParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 10;
            MethodVal(30);
            Console.WriteLine($"Parameters by Value {first}");  //30

            int second = 10;
            MethodByRef(ref second);
            Console.WriteLine($"Parameters by Reference {second}"); //20

            int third;
            MethodByOut(out third);
            Console.WriteLine($"Parameters by Reference(out) {third}");
        }

        static void MethodVal(int first)
        {
            first = 20;
        }

        static void MethodByRef(ref int first)
        {
            first = 20;
        }

        static void MethodByOut(out int first)
        {
            first = 30; // Compile Error if 'first' is not assigned any value.
        }

        static void MethodUsingIn(in int number)
        {
            //number = 12;
        }
    }
}
