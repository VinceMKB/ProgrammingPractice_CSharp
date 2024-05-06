using System;
using System.Linq;
using MergeSortedArray;

namespace MergeSortedArray
{

    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n) 
        {
            var filter_arraryOne = nums1.Take(m).Where(x => x != 0);
            var filter_arrayTwo = nums2.Take(n).Where(x => x != 0);

            int[] merge_array = filter_arraryOne.Concat(filter_arrayTwo).OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(",", merge_array));

        }
    }

    class Program : Solution
    {
        static void Main(string[] args)
        {
            
            Solution ObjSol = new Solution();

            int[] first_array = {1, 2, 4, 0, 0, 0};
            int[] second_array = {2, 4, 6, 9};
            int size_first = 3;
            int size_second = 4;

            ObjSol.Merge(first_array, size_first, second_array, size_second);

        }
    }
}
