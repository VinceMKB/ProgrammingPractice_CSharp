using System;

namespace HouseRobber
{
    public class Solution
    {
        public int Rob(int[] nums)
        {
            int stolen_num = 0;
            for(int i = 0; i < nums.Length; i += 2)
            {
                Console.WriteLine($"The money :R {nums[i]}K");
                stolen_num = stolen_num + nums[i];
            }
            return stolen_num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] in_array = {2, 7, 9, 3, 1};
            int result = solution.Rob(in_array);
            Console.WriteLine($"The largest sum of money is: {result}");
        }
    }
}


