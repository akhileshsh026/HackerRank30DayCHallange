using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8DictonaryandMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phonebook = new Dictionary<string, int>();

            int n = Convert.ToInt32(Console.ReadLine());
            string name; int no;
            for (int i = 0; i < n; i++)
            {
                name = Console.ReadLine();
                no = Convert.ToInt32(Console.ReadLine());
                phonebook.Add(name, no);
            }

            foreach (var item in phonebook)
            {
                Console.WriteLine("the name is {0}:, and no is {1}:",item.Key,item.Value);
            }

            List<string> naam = new List<string>();
            
            string name1 = ".";
            while (name1!= String.Empty)
            {
                name1 = Console.ReadLine();
                naam.Add(name1);
            }

            foreach (var item in naam)
            {
                Console.WriteLine("List items are",item);
            }

            Console.ReadKey();

        }
    }
}
