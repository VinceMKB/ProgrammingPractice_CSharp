using System;

namespace Sqrt_Number
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            if (x < 2)
            {
                return x;
            }

            int start = 1;
            int end = x;

            // Corrected the loop condition and precision calculation
            while (start < end)
            {
                int mid = (start + end) / 2;
                if (mid * mid < x)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }

            // Check if the square of the start is less than or equal to x
            if (start * start <= x)
            {
                return start;
            }
            else
            {
                // If the square of the start is greater than x, return the previous value
                return start - 1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution ObjSol = new Solution();
            int number_in = 4;

            int result = ObjSol.MySqrt(number_in);
            Console.WriteLine($"Square root of {number_in} is {result}");
        }
    }
}
