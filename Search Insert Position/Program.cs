using System;

namespace Search_Insert_Position
{
    // https://leetcode.com/problems/search-insert-position/
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5 };
            int target = SearchInsert(nums, 7);
            Console.WriteLine(target);
        }

        public static int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}
