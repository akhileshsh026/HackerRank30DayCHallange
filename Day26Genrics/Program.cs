using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day26Genrics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intarray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intarray[i] = Convert.ToInt32(Console.ReadLine());
            }

            n = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            PrintArray<Int32>(intarray);
            PrintArray<String>(stringArray);
            Console.ReadKey();
        }

        public static void PrintArray<T>(T[] intArray)             
        {
            foreach (var item in intArray)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }



    }
}
