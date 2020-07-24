using System;

namespace Shuffle_Cards
{
    class Program
    {
        static void randomize(int[] arr, int n)
        {
            // 1. Create a Random class
            Random r = new Random();

            // 2. Loop through the array from the last element
            for(int i=n-1; i>0; i--)
            {
                // 3. In the loop, pick a random index
                int j = r.Next(0, i + 1);

                // 4. And then will shuffle the elements by swapping the index
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            // Print out the outcome
            for(int i=0; i<n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int n = input.Length;

            randomize(input, n);
        }
    }
}
