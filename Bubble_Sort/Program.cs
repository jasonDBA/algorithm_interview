using System;

namespace Bubble_Sort
{
    class Program
    {
        /*
        [Question]
        https://www.hackerrank.com/challenges/ctci-bubble-sort/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=sorting
         */
        static void countSwaps(int[] a)
        {
            // Example:
            // Input: 3 and 3 2 1
            // Output: swap=3 and first element=1, last element=3
            int swap = 0;
            for(int i=0; i<a.Length; i++)
            {
                for(int j=0; j<a.Length-1; j++)
                {
                    if(a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        swap++;
                    }
                }
            }
            Console.WriteLine("Swap: " + swap);
            Console.WriteLine("The first element: " + a[0]);
            Console.WriteLine("The last element: " + a[a.Length - 1]);
        }

        static void Main(string[] args)
        {
            Console.Write("The number of elements in your array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Your array: ");
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            
            countSwaps(a);
        }
    }
}
