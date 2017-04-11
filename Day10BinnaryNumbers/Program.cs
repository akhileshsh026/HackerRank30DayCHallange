using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10BinnaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // UptoUwantenterstrng();
            // smallest way to convert from decimal to Binary.
            int N = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(N, 2);
            Console.WriteLine(binary);
            Console.ReadKey();


            // any base type to anytpe 
            /*
               String number = "100";
               int fromBase = 16;
               int toBase = 10;

               String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);  
           */


        }

        public static void FullProgram()
        {
            int num;
            Console.Write("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            int quot;
            string rem = "";
            while (num >= 1)
            {
                quot = num / 2;
                rem += (num % 2).ToString();
                num = quot;
            }
            string bin = "";
            for (int i = rem.Length - 1; i >= 0; i--)
            {
                bin = bin + rem[i];
            }
            Console.WriteLine("The Binary format for given number is {0}", bin);
            Console.Read();

        }

        private static void UptoUwantenterstrng()
        {
            string s = string.Empty;
            int N = 5;
            while (N != 0)
            {

                s += Console.ReadLine();
                N--;
            }

            Console.WriteLine(s);
        }
    }
}
