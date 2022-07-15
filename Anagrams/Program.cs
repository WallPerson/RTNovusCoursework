using System;
using System.Collections.Generic;

namespace Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string words = "qqqq,parts,traps,arts,rats,starts,tarts,rat,art,tar,tars,stars,stray";

            string target = "star";

            List<string> wordList = new List<string>();

           
            foreach (string word in words.Split(','))
                wordList.Add(word);


           foreach (string word in wordList)
            {
                if (word.Length == target.Length)
                {
                    string curWord = word;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (curWord.Contains(target[i]))
                        {
                            
                            curWord = curWord.Remove(curWord.IndexOf(target[i],0));

                            if (curWord.Length == 0)
                                Console.WriteLine(word + " is an anagram of star");
                            

                        }
                        
                            


                    }
                    
                }



            }

        }
    }
}
