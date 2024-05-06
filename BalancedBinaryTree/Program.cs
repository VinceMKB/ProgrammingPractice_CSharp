using System;

namespace BalancedBinaryTree
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

        public int Height(TreeNode side)
        {
            if(side == null)
            {
                return 0;
            }

            return 1 + Math.Max(Height(side.left), Height(side.right));
        }

        public bool isBalanced(TreeNode m_root)
        {
            if(m_root == null)
            {
                return true;
            }

            int LeftSide_Height = Height(m_root.left);
            int RightSide_Height = Height(m_root.right);

            return Math.Abs(LeftSide_Height - RightSide_Height) <= 1 && isBalanced(m_root.left) && isBalanced(m_root.right);

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


            bool result = solution.isBalanced(root);

            Console.WriteLine($"Is the BinaryTree balanced: {result.ToString()}");
        }
    }
}
