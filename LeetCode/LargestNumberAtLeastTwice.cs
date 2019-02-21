using System;

namespace LeetCode
{
    class LargestNumberAtLeastTwice
    {
        public static void Test1()
        {
            int[] nums = {3, 6, 1, 0};
            int res = Solution1(nums);

            if (res != 1)
            {
                throw new InvalidOperationException();
            }
        }

        public static void Test2()
        {
            int[] nums = {3, 6, 1, 0};
            int res = Solution2(nums);

            if (res != 1)
            {
                throw new InvalidOperationException();
            }
        }
        static int Solution1(int[] nums)
        {
            int largest = nums[0];
            int largestIndex = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (largest < nums[i])
                {
                    largest = nums[i];
                    largestIndex = i;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] * 2 > largest && i != largestIndex)
                {
                    return -1;
                }
            }
            return largestIndex;
        }

        static int Solution2(int[] nums)
        {
            int max = nums[0];
            int maxIndex = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    if (nums[i] >= max*2)
                        maxIndex = i;
                    else
                        maxIndex = -1;

                    max = nums[i];
                }
                else if (nums[i] < max)
                {
                    if (max < nums[i]*2)
                    maxIndex = -1;
                }
            }
            return maxIndex;
        }

    }
}
