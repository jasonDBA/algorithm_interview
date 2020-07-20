using System;

namespace Minimum_Absolute_Difference
{
    class Program
    {
        /*
        [Question]
        https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=greedy-algorithms
         */

        static int minimumAbsoluteDifference(int[] arr)
        {
            Array.Sort(arr);
            int miniumDiff = Math.Abs(arr[0] - arr[1]);

            for(int i=1; i<arr.Length-1; i++)
            {
                int tempDiff = Math.Abs(arr[i] - arr[i + 1]);
                if (tempDiff < miniumDiff) miniumDiff = tempDiff;
            }
            return miniumDiff;

        }

        static void Main(string[] args)
        {
            Console.Write("The number of elements in array: ");
           ;int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("The array: ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            
            int result = minimumAbsoluteDifference(arr);
            Console.WriteLine("The minimum absolute difference in the array: " + result);
        }
    }
}
