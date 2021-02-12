using System;

namespace SortingIntArrayUsingForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of integer array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter integer values one by one and press enter: ");
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Console.WriteLine(arr[length - 1]);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Integer array to be sorted: {string.Join(',', arr)}");

            int[] sortedarray = new int[length];
            Array.Copy(arr, sortedarray, arr.Length);
            Array.Sort(sortedarray);
            Console.WriteLine($"Sorted int copied array: {string.Join(',', sortedarray)}");


            for (int i = 0; i < length; i++)    //element to compare
            {
                for (int j = i+1; j < length; j++)      // all other elements of array
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine($"Sorted int array: {string.Join(',', arr)}");

            Array.Copy(arr, sortedarray, arr.Length);
            Array.Sort(arr);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
