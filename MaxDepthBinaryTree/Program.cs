using System;

namespace SameTree
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

        public int MaxDepth(TreeNode m_root)
        {
            
            if(m_root == null)
            {
                return 0;
            }

            int left_level = MaxDepth(m_root.left);
            int right_level = MaxDepth(m_root.right);

            return Math.Max(left_level, right_level) + 1;
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

            root.left.left = solution.CreateTreeNode(4);
            root.left.left.left = solution.CreateTreeNode(8);

            int result = solution.MaxDepth(root);

            Console.WriteLine($"The max depth is: {result}");
        }
    }
}
