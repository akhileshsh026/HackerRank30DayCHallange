using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int N = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write(item);
                Console.Write(' ');
            }

        }
    }
}
