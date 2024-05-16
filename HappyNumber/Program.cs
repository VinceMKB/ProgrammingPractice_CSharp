using System;

namespace HappyNumber
{
    public class Solution
    {
        public bool isHappy(int num)
        {
            HashSet<int> seenNumbers = new HashSet<int>();
            int currentNum = num;

            while(currentNum != 1 && !seenNumbers.Contains(currentNum))
            {
                seenNumbers.Add(currentNum);
                int sum_of_squares = 0;
                while(currentNum > 0)
                {
                    int digit = currentNum % 10;
                    sum_of_squares += digit * digit;
                    currentNum /= 10;
                }
                currentNum = sum_of_squares;
            }

            return currentNum == 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int number = 2;
            bool result = solution.isHappy(number);
            Console.Write(result);

        }
    }
}


