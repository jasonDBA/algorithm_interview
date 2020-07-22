using System;
using System.Collections.Generic;
using System.Linq;

namespace Two_Sum
{
    class Program
    {
        /*
         * Given an array of integers, 
         * return indices of the two numbers such that they add up to a specific target.
         *
         * Example:
         * Input: nums = [2, 7, 11, 15], target = 9
         * Output: [0, 1]
         */

        static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            //for(int i=0; i<nums.Length; i++)
            //{
            //    for(int j=i+1; j<nums.Length; j++)
            //    {
            //        if(nums[i] + nums[j] == target)
            //        {
            //            result[0] = i;
            //            result[1] = j;
            //        }
            //    }
            //}
            //// time complexity = O(n^2)

            Dictionary<int, int> map = new Dictionary<int, int>();
            
            for(int i=0; i<nums.Length; i++)
            {
                int value = target - nums[i];
                if(map.ContainsKey(value))
                {
                    result[0] = map[value];
                    result[1] = i;
                } else
                {
                    map[nums[i]] = i;
                }
            }
            // time complexity = O(n)
            return result;
        }

        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSum(nums, target);

            foreach (int item in result) Console.Write("{0} ", item);
        }
    }
}
