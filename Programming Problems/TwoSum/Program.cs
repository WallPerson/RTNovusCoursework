using System;
using System.Collections.Generic;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var sum = ( FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10));

            Console.WriteLine(sum.Item1.ToString() + " and " + sum.Item2.ToString());
        }


       public static Tuple<int,int> FindTwoSum(List<int> list, int x)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {

                for (int j = 0; j < list.Count - 1; j++)
                {
                    int temp = list[i] + list[j];

                    if (temp == x)
                    {


                        return Tuple.Create(list[i], list[j]);

                    }


                }

                

            }
            return null;
        }
    }
}
