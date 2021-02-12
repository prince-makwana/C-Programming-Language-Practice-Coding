using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemoApp
{
    class GenericClassSample<T>
    {
        public void Print(T param)
        {
            Console.WriteLine($"Parameter: {param}");
        }
    }
}
