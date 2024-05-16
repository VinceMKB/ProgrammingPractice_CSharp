using System;

namespace NumberOneBits
{
    public class Solution
    {
        public int HammingWeight(int num) 
        {
            string num_binary = Convert.ToString(num, 2);
            int count = 0;

            for(int i = 0; i < num_binary.Length; i++)
            {
                if(num_binary[i] == '1')
                {
                    count++;
                }
            }

            return count;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int in_num = 2147483645;

            int result = solution.HammingWeight(in_num);
            Console.WriteLine($"The reversed bit is: {result}");

        }
    }
}


