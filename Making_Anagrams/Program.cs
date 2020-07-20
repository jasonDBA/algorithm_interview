using System;
using System.Collections.Generic;

namespace Making_Anagrams
{
    class Program
    {
        /*
        [Question]
        https://www.hackerrank.com/challenges/ctci-making-anagrams/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
         */

        static int makeAnagram(string a, string b)
        {
            char[] charA = a.ToLower().ToCharArray();
            char[] charB = b.ToLower().ToCharArray();

            int result = 0;

            Dictionary<char, int> alphabets = new Dictionary<char, int>()
            {
                { 'a', 0 }, { 'b', 0 }, { 'c', 0 }, { 'd', 0 }, { 'e', 0 },
                { 'f', 0 }, { 'g', 0 }, { 'h', 0 }, { 'i', 0 }, { 'j', 0 },
                { 'k', 0 }, { 'l', 0 }, { 'm', 0 }, { 'n', 0 }, { 'o', 0 },
                { 'p', 0 }, { 'q', 0 }, { 'r', 0 }, { 's', 0 }, { 't', 0 },
                { 'u', 0 }, { 'v', 0 }, { 'w', 0 }, { 'x', 0 }, { 'y', 0 },
                { 'z', 0 },
            };

            for(int i=0; i<charA.Length; i++)
            {
                char chr = charA[i];
                alphabets[chr]++;
            }

            for(int j=0; j<charB.Length; j++)
            {
                char chr = charB[j];
                alphabets[chr]--;
            }

            foreach(var chr in alphabets)
            {
                result += Math.Abs(chr.Value);
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a String (a): ");
            string a = Console.ReadLine();

            Console.Write("Enter another String (b): ");
            string b = Console.ReadLine();

            int res = makeAnagram(a, b);
            Console.Write("The total number of characters removed: " + res);
        }
    }
}
