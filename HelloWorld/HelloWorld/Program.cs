using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerProgram
{
    class GFG
    {
        static void Main()
        {
            unsafe
            {
                int n = 10;
                int* p = &n;
                Console.WriteLine("Value: {0}", n);
                Console.WriteLine("Address: {0}", (int)p);
                Console.ReadKey();
            }
        }
    }
}