using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndobjects
{
    class ClassesAndObject
    {
        static void Main()
        {
            Person p = new Person(30);
            p.amIOld();
            for (int j = 0; j < 3; j++)
            {
                p.yearPasses();
            }
            p.amIOld();
            Console.WriteLine();
            Console.ReadLine();

        }
       
    }

    class Person
    {
        public int age;
        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge
            if (initialAge >=0)
            {
                age = initialAge;
            }
            
            else if(initialAge <0 && initialAge >= -5)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }

        }
        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console 
            if( age <13)
            {
                Console.WriteLine("You are young.");
            } else if (age>=13 && age<18)
            {
                Console.WriteLine("You are a teenager. ");
            } else if (age >= 18 && age <= 33)
                Console.WriteLine("You are old.");
        }

        public void yearPasses()
        {
            // Increment the age of the person in here
            age += 1;
        }

    }
}

