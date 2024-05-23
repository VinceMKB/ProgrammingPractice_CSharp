using System;

namespace ThreeSum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums) 
        {
            Array.Sort(nums);
            int target = 0;
            int n = nums.Length;
            IList<IList<int>> result = new List<IList<int>>();

            for(int i = 0; i < n - 2; i++)
            {
                if(i > 0 && nums[i]==nums[i - 1])
                {
                    continue;
                }
                int left = i + 1;
                int right = n - 1;

                while(left < right)
                {
                    int current_sum = nums[i] + nums[left] + nums[right];
                    if(current_sum == target)
                    {
                        result.Add(new List<int>{nums[i], nums[left], nums[right]});

                        while(left < right && nums[left] == nums[left + 1])
                        {
                            left++;
                        }
                        while(left < right && nums[right] == nums[right - 1])
                        {
                            right--;
                        }
                        left++;
                        right--;
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
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] in_array = {-1, 0, 1, 2, -1, -4};
            IList<IList<int>> result = solution.ThreeSum(in_array);

            foreach (var triplet in result)
            {
                Console.Write($"[{string.Join(",", triplet)}]");
            }

        }
    }
}
