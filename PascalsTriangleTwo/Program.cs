
using System;
using System.Collections.Generic;
//Pascal's Triangle is a triangular array of the binomial coefficients
namespace PascalsTriangleTwo
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

        public IList<int> GetRow(int row_index)
        {
            return Generate(row_index + 1)[row_index];
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int rowToGet = 6;
            int numOfRows = 7;

            Console.WriteLine("GetRow Function: ");
            IList<int> results = solution.GetRow(rowToGet);
            Console.WriteLine(string.Join(" ", results));

            Console.WriteLine("Generate Function: ");
            IList<IList<int>> list =  solution.Generate(numOfRows);
            foreach(var innerlist in list)
            {
                Console.WriteLine(string.Join(" ", innerlist));
            }

        }
    }
}
