using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Recursion
{
    class Program
    {
        static void Main(string[] args)
        {  
            int N = Convert.ToInt32(Console.ReadLine());

            int fact=  factorial(N);

            Console.WriteLine(fact);


        }

        public static int factorial(int N )
        {       // base case : where our algorithum will stop .
            if (N <= 1)
                return 1;    // multiplicative identity .
            else     // recursive case : where our algorithum will repeted again and again .
                return N * factorial(N - 1);
        }
    }
}
