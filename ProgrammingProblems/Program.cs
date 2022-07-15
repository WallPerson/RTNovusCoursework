using System;

namespace ProgrammingProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Longest Sequence

            string seq = "1,2,1,1,0,3,1,0,0,2,4,1,0,0,0,0,2,1,0,3,1,0,0,0,6,1,3,0,0,0";
            int highest = 0;
            int count = 0;
            foreach (char i in seq)
            {
                
                if (i != ',')
                {
                    //Console.WriteLine(i);
                    if (i == '0')
                    {
                        count++;
                    }

                    if (i != '0')
                    {
                        if (count > highest)
                        {
                            highest = count;

                            count = 0;
                        }


                    }


                }


                

            }
            Console.WriteLine(highest);

        }
    }
}
