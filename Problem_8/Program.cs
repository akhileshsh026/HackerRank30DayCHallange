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
            List<string> klist = new List<string>();


            Console.WriteLine("Enter how many records you want to Enter");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                phlst.Add(Console.ReadLine(), Console.ReadLine());
            }
            
            do
            {
                klist.Add(Console.ReadLine());
            } while (!klist.Contains(String.Empty));


            for (int i = 0; i < klist.Count; i++)
            {
                if (klist[i].ToString() == phlst.ElementAt(i).Key)
                {
                    Console.WriteLine(klist[i].ToString() + " = " + phlst[klist[i]]);
                }
                else
                {
                    
                }
            }

        }
    }
}
