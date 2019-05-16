using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17TDD
{
    class PrimeMethods
    {



        public static int GetPrime(int num)//sequence number
        {
            bool isPrime;
            int prime = 2;
            int count = 0;
            List<int> factors = new List<int>();
            List<int> primes = new List<int>();

            while (count < num)
            {
                factors.Clear();
                isPrime = true;

                for (int i = prime - 1; i > 0; i--)// i= 1
                {
                    if (prime % i == 0)
                    {
                        factors.Add(i);//list has : 1
                    }
                }
                if (factors.Count > 1)
                {
                    isPrime = false;

                }

                if (isPrime)
                {
                    count++;
                    prime++;
                }
                else
                {
                    prime++;
                }
            }

            return prime - 1;

        }

        //This is the new solution for the ORIGINAL METHOD.just so you know, 19 is the 8th Prime # and Anna forgot to put that down.










    }
}
