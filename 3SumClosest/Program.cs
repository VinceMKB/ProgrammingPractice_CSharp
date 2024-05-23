using System;

namespace ThreeSumClosest
{
    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int closest_sum = int.MaxValue;

            for(int i = 0; i < n - 2; i++)
            {
                int left = i + 1;
                int right = n - 1;

                while(left < right)
                {
                    int current_sum = nums[i] + nums[left] + nums[right];
                    //Check if the current sum is closer to the target
                    if(Math.Abs(current_sum - target) < Math.Abs(closest_sum - target))
                    {
                        closest_sum = current_sum;
                    }

                    if(current_sum == target)
                    {
                        return closest_sum;
                    }
                    else if(current_sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            
            return closest_sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] in_array = {-1, 2, 1, -4};
            int target = 1;
            int result = solution.ThreeSumClosest(in_array, target);
            Console.WriteLine(result);
        }
    }
}
