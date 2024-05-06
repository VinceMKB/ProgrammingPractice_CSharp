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
        public bool isSymmetricTree(TreeNode m_root)
        {
            return isMirror(m_root, m_root);
        }
        public bool isMirror(TreeNode tree_one, TreeNode tree_two)
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

            return isMirror(tree_one.left, tree_two.right) && isMirror(tree_one.right, tree_two.left);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            //Root Level
            TreeNode root = solution.CreateTreeNode(1);

            //Second Level
            root.left = solution.CreateTreeNode(2);
            root.right = solution.CreateTreeNode(2);

            //Third Level
            root.left.left = solution.CreateTreeNode(4);
            root.right.left = solution.CreateTreeNode(6);

            //Third Level
            root.left.right = solution.CreateTreeNode(6);
            root.right.right = solution.CreateTreeNode(4);


            bool result = solution.isSymmetricTree(root);

            Console.WriteLine($"Is the tree symmetric: {result.ToString()}");
        }
    }
}