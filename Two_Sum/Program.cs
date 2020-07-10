using System;

namespace Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                x = nums[i];
                for (int j = 1; j < nums.Length; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    y = nums[j];

                    if ((x + y) == target)
                    {
                        int[] found = { i, j };
                        return found;
                    }
                }
            }

            int[] nope = { 0 };
            return nope;
        }
    }
}
