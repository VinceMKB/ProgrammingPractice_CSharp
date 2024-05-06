using System;

namespace ArrayPlusOne
{
    public class Solution
    {
        public int[] Plus_One(int[] digits)
        {

            string num_s = "";
            int num_add = 0;

            foreach(int num in digits)
            {
                num_s += num.ToString();
            }
            num_add = int.Parse(num_s) + 1;
            num_s = num_add.ToString();

            int[] array = new int[num_s.Length];

            for(int i = 0; i < num_s.Length; i++)
            {
                array[i] = int.Parse(num_s[i].ToString());
            }

            return array;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution ObjSol = new Solution();
            int[] array = {9};
            
            int[] result = ObjSol.Plus_One(array);

            foreach(int start in result)
            {
                Console.WriteLine($"Number in Array: {start}");
            }
    
        }
    }
}
