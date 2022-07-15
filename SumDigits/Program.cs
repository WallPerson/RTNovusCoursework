using System;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to be summed");
            int num = Convert.ToInt32(Console.ReadLine());
            string numStr = num.ToString();
            int total = 0;

            for(int i = 0; i < numStr.Length;i++)
            {
                total += int.Parse(numStr[i].ToString());

                
            }
            Console.WriteLine(total);
        }
    }
}
