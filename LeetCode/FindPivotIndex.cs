using System;

namespace LeetCode
{
    class FindPivotIndex
    {
        public static void Test()
        {
            int[] nums = {1, 7, 3, 6, 5, 6};
            int res = Solution(nums);

            if (res != 3)
            {
                throw new InvalidOperationException();
            }
        }
        static int Solution(int[] nums)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                rightSum += nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int pivot = nums[i];
                leftSum += pivot;
                if (leftSum == rightSum)
                {
                    return i;
                }
                rightSum -= pivot;
            }
            return -1;

        }
    }
}
