using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    class ConditionalOperatorProgram
    {
        static void Main()
        {
           

       int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) // checking weather the interger is even or odd
            {

                if (n > 2 && n < 5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if (n > 6 && n <= 20)
                {
                    Console.WriteLine("Weird");
                }
                else if (n > 20)
                {
                    Console.WriteLine("Not Weird");
                }

            }
            else Console.WriteLine("Weird");


            Console.ReadLine();

        }
    }
}
