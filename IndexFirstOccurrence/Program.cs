using System;
using System.Collections.Generic;

namespace IndexFirstOccurrence
{
    public class Solution
    {
        public List<int> StrStr(string haystack, string needle)
        {
            List<int> positions = new List<int>();
            int position = 0;

            while ((position = haystack.IndexOf(needle, position, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                positions.Add(position);
                position += needle.Length; // Move to the next position after the found needle
            }

            return positions; // Return the list of positions
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution ObjSol = new Solution();
            string hay = "sadbutsad";
            string pin = "sad";

            List<int> result = ObjSol.StrStr(hay, pin);
            Console.WriteLine($"The words are found at positions: {string.Join(", ", result)}");
        }
    }
}
