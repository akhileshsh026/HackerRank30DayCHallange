using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Dictionary<string, string> phlst = new Dictionary<string, string>();
            Console.WriteLine("Enter how many records you want to Enter");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                phlst.Add(Console.ReadLine(), Console.ReadLine());
            }
            
            foreach (var item in phlst.Keys)
            {
                Console.WriteLine(item+" = "+phlst[item]);
            }
            Console.ReadLine();

            List<string> klist = new List<string>();
            do
            {
                klist.Add(Console.ReadLine());
            } while (klist.Any());
        }
    }
}
