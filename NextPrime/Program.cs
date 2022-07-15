using System;
using System.Collections.Generic;

namespace NextPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter position of prime number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The next prime number is: "+ nextPrime(x));
            }

        public static int nextPrime(int x)
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0) { x++; i = 2; }
            }
            return x;





        }
        }


    }
