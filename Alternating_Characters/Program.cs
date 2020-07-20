using System;
using System.Linq;

namespace Alternating_Characters
{
    class Program
    {
        /*
        [Question]
        https://www.hackerrank.com/challenges/alternating-characters/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
         */
        static int alternatingCharacters(string s)
        {
            int count = 0;
            for(int i=0; i<s.Length-1; i++)
            {
                if(s[i] == s[i + 1])
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.Write("How many string? ");
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                Console.Write("Enter string ({0}): ", qItr);
                string s = Console.ReadLine();

                int result = alternatingCharacters(s);
                Console.WriteLine("The number of removed elements: " + result);
            }
        }
    }
}
