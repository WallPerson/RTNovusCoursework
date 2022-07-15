using System;

namespace StarsOnScreen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 5;
            int padding = Console.WindowWidth /2;
            for (int spacing = 1; spacing <= row; spacing++)
            {

                for (int i = 1; i <= padding; i++)
                    Console.Write(" ");
                padding--;

                for (int i = 1; i <= 2 * spacing - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }

        }
    }
}

