﻿using System;
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
            //Console.WriteLine("Enter the Number");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int[] A = new int[N];
            //string[] s = new string[N]; 
            //for (int i = 0; i < N; i++)
            //{

            //        s[i] = Console.ReadLine();


            //}

            //for (int i = N-1; i >=0 ; i--)
            //{
            //    Console.Write(A[i]);
            //}

            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            foreach (var item in arr)
            {
                Console.Write(item);
            }



            Console.ReadKey();
        }
    }
}
