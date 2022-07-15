using System;
using System.Collections.Generic;

namespace PrimeNum
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Enter position of prime number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            List<int> prime = new List<int>();
            int count;
            for (int i = 1; i < 101; i++)
            {
                count = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count = 1;

                            if (prime.Count == x)
                            {
                                Console.WriteLine("The " + x + " prime number was " + prime[x - 1].ToString());
                                x = 0;
                                break;
                               
                            }
                            
                        }
                    }
                    if (count == 0)
                    {
                        prime.Add(i);
                    }
                    

                }


            }
        }
    }
}

