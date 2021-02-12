using System;

namespace NullableTypeAnonymousTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Type, Reference Type

            /*int i = null;*/       //Value type variable cannot be assigned null.
                                    //But Reference type variable can be assigned null.

            int? i = null;          //In latest version of C#, they introduced Nullable types, which is valid.
            bool? flag = null;

            if (flag.HasValue)
            {
                bool test = flag.Value;
            }

            //Anonymous Types - In some scenarios, if you have set of read only properties, as we know that
            //read only properties means, you can initialize them but after that you cannot change them.
            //So, instead of creating a class and then declare read-only field and initialize them, in C#
            //you can create an anonymous type. Anonymous Type means a class or a type without name,
            //using keyword new and braces. Inside this you can initialize the properties.

            var anonymousTypeVariable = new { CompanyName = "ABC Corp", Year = 1998 };
            Console.WriteLine(anonymousTypeVariable.CompanyName);
            Console.WriteLine(anonymousTypeVariable.Year);

            var iSample = 10;
            var strSample = "John";

        }
    }
}
