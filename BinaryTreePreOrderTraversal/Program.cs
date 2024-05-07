using System;
using System.Collections.Generic;
using BinaryTreePreOrderTraversal;


namespace BinaryTreePreOrderTraversal
{
    public class BinaryNode
    {
        public int Data {get; set;}
        public BinaryNode? Left {get; set;}
        public BinaryNode? Right {get; set;}

        public BinaryNode()
        {
            Data = 0;
            Left = null;
            Right = null;
        }

        public BinaryNode(int value)
        {
            Data = value;
            Left = null;
            Right = null;
        }

        public BinaryNode(int value, BinaryNode? left, BinaryNode? right)
        {
            Data = value;
            Left = left;
            Right = right;
        }
    }

    public class Solution
    {
        public IList<int> list = new List<int>();
        public BinaryNode CreateBinaryNode(int data)
        {
            BinaryNode new_node = new BinaryNode(data);
            new_node.Left = new_node.Right = null;

            return new_node;
        }

        public IList<int> PreOrderTraversal(BinaryNode? root)
        {
            if(root == null)
            {
                return list;
            }

            list.Add(root.Data);
            PreOrderTraversal(root.Left);
            PreOrderTraversal(root.Right);

            return list;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            // 1, 2, 4, 5, 9, 3, 6, 7, 15
            BinaryNode root = solution.CreateBinaryNode(1);

            root.Left = solution.CreateBinaryNode(2);
            root.Right = solution.CreateBinaryNode(3);

            root.Left.Left = solution.CreateBinaryNode(4);
            root.Left.Right = solution.CreateBinaryNode(5);

            root.Right.Left = solution.CreateBinaryNode(6);
            root.Right.Right = solution.CreateBinaryNode(7);

            root.Left.Right.Left = solution.CreateBinaryNode(9);
            root.Right.Right.Left = solution.CreateBinaryNode(15);

            IList<int> result = solution.PreOrderTraversal(root);
            Console.WriteLine(string.Join(", ", result));

        }
    }
}


