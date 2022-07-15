using System;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "hello world";

            for(int i = 1; i <= str.Length; i++)
            {
                Console.Write(str[str.Length-i]);


            }
        }
    }
}
