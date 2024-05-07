
using System;

namespace PathSumBinaryTree
{
    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int value = 0, TreeNode left = null, TreeNode right = null)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution
    {

        public TreeNode CreateTreeNode(int data)
        {
            TreeNode new_node = new TreeNode(data);
            return new_node;
        }

        public bool hasPathToSum(TreeNode m_root, int m_targetsum)
        {
            return hasSumHelper(m_root, m_targetsum, 0);
        }

        public bool hasSumHelper(TreeNode helper_root, int helper_targetsum, int current_sum)
        {
            if(helper_root == null)
            {
                return false;
            }

            current_sum += helper_root.value;

            if(current_sum == helper_targetsum)
            {
                return true;
            }

            return hasSumHelper(helper_root.left, helper_targetsum, current_sum) || hasSumHelper(helper_root.right, helper_targetsum, current_sum);   

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            TreeNode root = solution.CreateTreeNode(1);

            root.left = solution.CreateTreeNode(2);
            root.right = solution.CreateTreeNode(3);

            root.right.right = solution.CreateTreeNode(5);
            root.right.left = solution.CreateTreeNode(7);

            root.left.left = solution.CreateTreeNode(4);
            root.left.right = solution.CreateTreeNode(11);

            root.left.left.left = solution.CreateTreeNode(8);

            int target_sum = 15;

            bool result = solution.hasPathToSum(root, target_sum);

            Console.WriteLine($"Found the path to equal to target: {result.ToString()}");
        }
    }
}
