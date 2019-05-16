using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            string willContinue = "y";

            Console.WriteLine("\n" +
                    "\n" +
                    "I will find you any prime number, in order, from the first prime number on.\n" +
                "");


            while (willContinue == "y")
            {
                
                Console.WriteLine("Which prime number are you looking for? ");

                int num = int.Parse(Console.ReadLine());

                Console.WriteLine(PrimeMethods.GetPrime(num));

                Console.WriteLine("Do you want to find another prime number? y/n");
                willContinue = Console.ReadLine().ToLower();

            }

            Console.WriteLine("Have a good day!");
            



        }
    }
}
