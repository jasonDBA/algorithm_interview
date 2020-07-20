using System;

namespace _2DArray
{
    class Program
    {
        /*
        [Question] 
        https://www.hackerrank.com/challenges/2d-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
         */

        static int hourglassSum(int[][] arr)
        {
            int sum = -63;
            for(int row=0; row<4; row++)
            {
                for(int col=0; col<4; col++)
                {
                    int top = arr[row][col] + arr[row][col + 1] + arr[row][col + 2];
                    int middle = arr[row + 1][col + 1];
                    int bottom = arr[row+2][col] + arr[row+2][col + 1] + arr[row+2][col + 2];

                    if (top + middle + bottom >= sum)
                    {
                        sum = top + middle + bottom;
                    }
                }
            }
            return sum;
        }


        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);
            Console.Write("Result: " + result);
        }
    }
}
