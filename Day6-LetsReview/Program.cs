using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LetsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Nunmber ");
            int N = Convert.ToInt32(Console.ReadLine());
            string[] s = new string[N];
            for (int i = 0; i < N; i++)
            {
                s[i] = Console.ReadLine();
            }

            // output
            string s1 = string.Empty; string s2 = string.Empty;
            Char[] arry = new char[100001];
            for (int i = 0; i < N; i++)
            {

                arry = s[i].ToCharArray();
                int j = arry.Length;
                for (int k = 0; k < j; k++)
                {
                    if (k == 0 || k % 2 == 0)
                    {

                        s1 += arry[k].ToString();
                    }
                    else
                        s2 += arry[k].ToString();
                }

                Console.WriteLine(s1 + " " + s2);
                s1 = string.Empty; s2 = string.Empty;
            }
            Console.ReadKey();
        }
    }
}

