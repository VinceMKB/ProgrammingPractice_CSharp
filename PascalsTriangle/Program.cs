﻿
using System;

namespace PascalsTriangle
{
    public class Solution
    {
        public IList<IList<int>> Generate(int num_rows)
        {
            var results = new List<IList<int>>();
            if(num_rows == 0)
            {
                return results;
            }

            results.Add(new List<int>{1});
            for(int i = 1; i < num_rows; i++)
            {
                var prev_row = results[i - 1];
                var new_row = new List<int>{1};

                for(int j = 1; j < i; j++)
                {
                    new_row.Add(prev_row[j - 1]+ prev_row[j]);
                }

                new_row.Add(1);
                results.Add(new_row);
            }

            return results;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int numrows = 7;

            IList<IList<int>> list = solution.Generate(numrows);
            foreach(var innerlist in list)
            {
                foreach(var element in innerlist)
                {
                    Console.Write($" {element} ");
                }
                Console.WriteLine();
            }
        }
    }
}
