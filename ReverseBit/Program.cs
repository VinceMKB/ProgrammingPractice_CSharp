using System;

namespace ReverseBit
{
    public class Solution
    {
        public uint reverseBit(uint num)
        {

            uint reversed = 0;
            for(int i = 0; i < 32; i++)
            {
                reversed = reversed << 1;
                if(num % 2 == 1)
                {
                    reversed++;
                }
                num = num >> 1;
            }

            return reversed;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            uint in_num = 43261596;

            uint result = solution.reverseBit(in_num);
            Console.WriteLine($"The reversed bit is: {result}");

        }
    }
}


