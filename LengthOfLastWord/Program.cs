using System;

namespace LengthOfLastWord
{
    public class Solution
    {
        public int LengthLastWord(string s)
        {
            s = s.TrimEnd();
            string last_word;
            int number_ofchar;

            int LastSpaceIndex = s.LastIndexOf(' ');
            if(LastSpaceIndex == -1)
            {
                last_word = s;
            }
            else
            {
                last_word = s.Substring(LastSpaceIndex + 1);
            }
            return number_ofchar = last_word.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution ObjSol = new Solution();
            string word = "If the target is not found in the array, the logic to return the position where it would be if inserted can be slightly different";

            int result = ObjSol.LengthLastWord(word);
            Console.WriteLine($"Last Word: {result}");
        }
    }
}
