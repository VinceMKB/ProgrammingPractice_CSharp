using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace IndexFirstOccurrence
{
    public class Solution
    {
        //This uses Binary Search
        public int SearchInsert(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length -1;
            Console.WriteLine($"high value is: {high}");
            
            while(low <= high)
            {
                int mid = low + (high - low)/2;

                if(nums[mid] == target)
                {
                    return mid;
                }
                else if(nums[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return low;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution ObjSol = new Solution();
            int[] array = { 1, 3, 5, 6 };
            int targ = 4;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int result = ObjSol.SearchInsert(array, targ);
            stopwatch.Stop();
            Console.WriteLine($"Index of first occurrence or insertion point: {result}");
            Console.WriteLine($"Execution Time: {stopwatch.Elapsed}");

        }
    }
}
