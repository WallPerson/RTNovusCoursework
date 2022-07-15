using System;
using System.Text.RegularExpressions;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word or sentence: ");
            string str = Console.ReadLine();
            string temp = "";

            str = Regex.Replace(str, @"[^A-Za-z]", "").ToLower();

            for (int i = 1; i <= str.Length; i++)
            {
                temp = temp +str[str.Length - i];


            }

            if (temp == str)
            {
                Console.WriteLine("This is a palindrome");

            }
            else
                Console.WriteLine("This is not a palindrome");

        }
    }
}
