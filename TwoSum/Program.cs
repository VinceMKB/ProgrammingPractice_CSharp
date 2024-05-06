using System;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> num_indices = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if(num_indices.ContainsKey(complement))
                {
                    return new int[]{num_indices[complement], i};
                }

                if(!num_indices.ContainsKey(nums[i]))
                {
                    num_indices.Add(nums[i], i);
                }
            }

            return new int[0];

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution ObjSol = new Solution();

            int[] array;
            array = new int[3]; //Creates the array with size of 4
            array[0] = 3;
            array[1] = 2;
            array[2] = 4;

            Console.WriteLine("Enter the target: ");
            int target = Convert.ToInt32(Console.ReadLine());

            int[] result = ObjSol.TwoSum(array, target);

            if (result.Length == 2)
            {
                Console.WriteLine($"Indices: {result[0]}, {result[1]}");
            }
            else
            {
                Console.WriteLine("No two elements sum up to the target.");
            }
        }
    }

}

