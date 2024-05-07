
using System;

namespace SingleNumbers
{
    public class Solution
    {
        public static int SingleNumber(int[] nums)
        {
            
            int unique_num = 0;

            foreach(int value in nums)
            {
                unique_num ^= value;
            }

            return unique_num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = {4, 4, 6, 8, 8};

            int result = Solution.SingleNumber(numbers);

            Console.WriteLine($"Returned result: {result}");

        }
    }
}
