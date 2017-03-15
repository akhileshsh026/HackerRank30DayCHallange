using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HackerRank
{
    class OPerators
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the MealCost");

            double mealCost = double.Parse(Console.ReadLine());
            int tipPercent = int.Parse(Console.ReadLine());
            int taxPercent = int.Parse(Console.ReadLine());

            // calulation Part
             
            double tip = mealCost * ((double)tipPercent / 100); //division by 100 always return 0. (Learn)
            double tax = mealCost * ((double)taxPercent / 100);
            double totalCost = mealCost + tip + tax;

            Console.WriteLine(Math.Round(totalCost));
            Console.ReadLine();

        }
    }
}
