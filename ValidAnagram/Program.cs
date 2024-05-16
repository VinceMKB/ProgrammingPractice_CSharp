namespace ValidAnagram
{
    public class Solution
    {
        public bool isAnagram(string s, string t)
        {
            char[] char_one = s.ToLower().ToCharArray();
            char[] char_two = t.ToLower().ToCharArray();

            Array.Sort(char_one);
            Array.Sort(char_two);

            return new string(char_one) == new string(char_two);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string str_one = "anagram";
            string str_two = "nagaram";

            bool result = solution.isAnagram(str_one, str_two);
            Console.WriteLine($"String '{str_one}' and '{str_two}' are anagrams.");

        }
    }
}


