
using System;

namespace PascalsTriangle
{
    public class Solution
    {
        public IList<IList<int>> Generate(int m_numrows)
        {
            var results = new List<IList<int>>();

            if(m_numrows == 0)
            {
                return results;
            }
            results.Add(new List<int>(1){1});

            if(m_numrows == 1)
            {
                return results;
            }
            results.Add(new List<int>(2){1, 1});
            if(m_numrows == 2)
            {
                return results;
            }

            for(int i = 2; i < m_numrows; i++)
            {
                IList<int> result = new List<int>();
                result.Add(1);

                for(var j = 1; j < i; j++)
                {
                    var number = results[i - 1][j - 1] + results[i - 1][j];
                    result.Add(number);
                }
                result.Add(1);
                results.Add(result);
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

            Console.WriteLine("Hello World!");
        }
    }
}
