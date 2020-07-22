using System;

namespace Move_Zeros
{
    class Program
    {
        /*
         * Given an array 'nums', write a function to move all 0's to the end of it
         * while maintaining the relative order of the non-zero elements
         * 
         * Example:
         * Input: [0, 1, 0, 3, 12]
         * Output: [1, 3, 12, 0, 0]
         * */

        static int[] MoveZeros(int[] nums)
        {
            // Answer
            // 1. Switch non-zero and zero numbers
            // 2. So that all non-zero numbers move to the left in array
            int zeroIndex = 0;
            for(int i=0; i<nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    int temp = nums[zeroIndex];
                    nums[zeroIndex] = nums[i];
                    nums[i] = temp;
                    zeroIndex++;
                }
            }

            return nums;
            // The time complexsity = O(n)
        }

        static void Main(string[] args)
        {
            int[] input = { 0, 1, 0, 3, 12 };
            int[] output = MoveZeros(input);
            
            foreach(int item in output)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
