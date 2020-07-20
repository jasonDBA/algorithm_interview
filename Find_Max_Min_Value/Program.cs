using System;

namespace Find_Max_Min_Value
{
    class Program
    {
        static int FindMaxValue(int[] arr)
        {
            int max = arr[0];
            for(int i=1; i<arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }
        static int FindMinValue(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }
        static void Main(string[] args)
        {
            int[] inputArr = { 1, 5, 33, 2, 990, 45, 86, 98 };

            int maxResult = FindMaxValue(inputArr);
            int minResult = FindMinValue(inputArr);

            Console.WriteLine("The maxium value: {0}", maxResult);
            Console.WriteLine("The minium value: {0}", minResult);
        }
    }
}
