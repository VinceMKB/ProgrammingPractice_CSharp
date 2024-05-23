using System;

namespace MaxArea
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                int currentArea = Math.Min(height[left], height[right]) * (right - left);
                maxArea = Math.Max(maxArea, currentArea);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] in_array = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int result = solution.MaxArea(in_array);
            Console.WriteLine($"The total area of this is: {result}");

            int[] smallArray = { 1, 1 };
            int smallResult = solution.MaxArea(smallArray);
            Console.WriteLine($"The total area of the small array is: {smallResult}");
        }
    }
}
