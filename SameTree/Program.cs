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
        public bool isSameTree(TreeNode tree_one, TreeNode tree_two)
        {
            if(tree_one == null && tree_two == null)
            {
                return true;
            }

            if(tree_one == null || tree_two == null)
            {
                return false;
            }

            if(tree_one.value != tree_two.value)
            {
                return false;
            }

            return isSameTree(tree_one.left, tree_two.left) && isSameTree(tree_one.right, tree_two.right);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            


            TreeNode root_one = solution.CreateTreeNode(1);
            root_one.left = solution.CreateTreeNode(2);
            root_one.right = solution.CreateTreeNode(3);

            TreeNode root_two = solution.CreateTreeNode(1);
            root_two.left = solution.CreateTreeNode(2);
            root_two.right = solution.CreateTreeNode(3);

            bool result = solution.isSameTree(root_one, root_two);

            Console.WriteLine($"Are Tree One and Tree Two the same: {result.ToString()}");
        }
    }
}