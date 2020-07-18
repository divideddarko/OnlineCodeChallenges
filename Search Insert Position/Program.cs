using System;

namespace Search_Insert_Position
{
    // https://leetcode.com/problems/search-insert-position/
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5 };
            int target = SearchInsert(nums, 4);
            Console.WriteLine(target);
        }

        public static int SearchInsert(int[] nums, int target)
        {
            int cc = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target || nums[i] > target)
                {
                    return i;
                }
                cc = i;
            }
            return (cc + 1);
        }
    }
}
