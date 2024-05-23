using System;
using System.Text;

namespace IntegerToRoman
{
    public class Solution
    {
        // Array of values and corresponding Roman numeral symbols
        private static readonly int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static readonly string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public string IntToRoman(int num)
        {
            StringBuilder roman = new StringBuilder();
            for (int i = 0; i < values.Length && num > 0; i++)
            {
                while (num >= values[i])
                {
                    num -= values[i];
                    roman.Append(symbols[i]);
                }
            }
            return roman.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            Console.Write("Enter an integer: ");
            int num;

            if (int.TryParse(Console.ReadLine(), out num) && num > 0)
            {
                string roman = solution.IntToRoman(num);
                Console.WriteLine($"The Roman numeral for {num} is {roman}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a positive integer.");
            }
        }
    }
}
