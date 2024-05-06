using System;

namespace Climbing_Stairs
{
    public class Solution
    {
        public int ClimbStairs(int x)
        {
            if(x == 0)
            {
                return 1; //If x = 0
            }

            if(x < 0)
            {
                return 0; //If x is less than 0
            }

            return ClimbStairs(x -1) + ClimbStairs(x - 2);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution ObjSol = new Solution();
            int num_in = 6;

            int result = ObjSol.ClimbStairs(num_in);

            Console.WriteLine($"You can climb {num_in} steps in {result} ways.");

        }
    }
}
