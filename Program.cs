using System;

namespace SmallerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 5, 9, 2, 4, 15, 7 };
            int[] smallerNumbers = SmallerNumbersThanCurrent(numbers);
            foreach(int i in smallerNumbers)
            {
                Console.Write($"{i} ");
            }
        }

        static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] smallerNums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        counter++;
                    }
                    if (j == nums.Length - 1)
                    {
                        smallerNums[i] = counter;
                        counter = 0;
                    }
                }
            }
            return smallerNums;
        }
    }
}
