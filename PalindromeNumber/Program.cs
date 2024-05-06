using System;

namespace PalindromeNumber
{
    public class Solution
    {
        public bool Is_Palindrome(int x)
        {
            string size_int = x.ToString();
            string fwd_int = x.ToString();
            string bwd_int = "";

            for (int i = size_int.Length - 1; i >= 0; i--)
            {
                bwd_int += size_int[i];
            }

            return fwd_int == bwd_int;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution ObjSol = new Solution();
            int number = 12521;
            bool result = ObjSol.Is_Palindrome(number);

            Console.WriteLine($"Is the number a palindrome? {result.ToString()}");
        }
    }
}
