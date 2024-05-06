using System;

namespace Add_Binary
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            int num_a = Convert.ToInt32(a, 2);
            int num_b = Convert.ToInt32(b, 2);
            
            int sum = num_a + num_b;

            string sum_str = Convert.ToString(sum, 2).PadLeft(8, '0');

            return sum_str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution ObjSol = new Solution();
            string str_one, str_two;
            str_one = "1010";
            str_two = "1010";

            string result = ObjSol.AddBinary(str_one, str_two);

            Console.WriteLine($"The added binary numbers are: {result}");

    
        }
    }
}
