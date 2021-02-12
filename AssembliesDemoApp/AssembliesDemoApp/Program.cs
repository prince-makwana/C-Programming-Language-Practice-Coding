using EcommBiz;
using System;

namespace AssembliesDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Assemblies - .exe(executable), dll(dynamic link library)
            //      Console App, Windows App etc are compiled into EXE

            //      Class Library project is compiled into DLL

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("This is Assemblies ddemo app");

            EcommBizLogic obj = new EcommBizLogic();
            Console.WriteLine(obj.GetCompanyName());
            Console.ReadLine();

            //GAC
            //Strong Named File - file with Public and Private Key Pair
        }
    }
}
