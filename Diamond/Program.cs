using System;

namespace Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int maxStar = 9;
            int padding = 0;
            int column = 0;

            while (row <= maxStar)
            {
                for (column = 0; column < maxStar / 2 - padding; column++)
                    Console.Write(" ");




                for (column = 0; column <= row; column++)
                    Console.Write("*");

                row += 2;
                padding++;
                Console.WriteLine();
            }

            row -= 2;
            padding--;

            while(row >= 0)
            {
                for (column=0; column < maxStar /2 - padding + 1; column++)
                    Console.Write(' ');

                for (column = 0; column < row -1; column++)
                    Console.Write("*");

                row -= 2;
                padding--;
                Console.WriteLine();
            }
            

        }
    }
}
