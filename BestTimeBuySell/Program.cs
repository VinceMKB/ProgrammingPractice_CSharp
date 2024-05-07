
using System;

namespace MaxProfits
{
    public class Solution
    {

        public int MaxProfit(int[] prices)
        {

            if(prices.Length == 0)
            {
                return 0;
            }

            int smallest_value = int.MaxValue;
            int max_profit = 0;

            for(int i = 0; i < prices.Length; i++)
            {
                if(prices[i] < smallest_value)
                {
                    smallest_value = prices[i];
                }
                else if(prices[i]- smallest_value > max_profit)
                {
                    max_profit = prices[i] - smallest_value;
                }
            }

            return max_profit;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Solution solution = new Solution();
            int[] new_prices = {7,1,5,3,6,4};

            int result_profit = solution.MaxProfit(new_prices);

            Console.WriteLine($"Returned profit: {result_profit}");

        }
    }
}
