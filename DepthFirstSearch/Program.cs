using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace IndexFirstOccurrence
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
        public BinaryNode CreateBinaryNode(int data)
        {

            BinaryNode new_Node = new BinaryNode(data);
            new_Node.Left = new_Node.Right = null;

            return new_Node;

        }

        //PreOrder (data, left, right)
        public void PreOrderBinaryNode(BinaryNode? root)
        {
            if(root == null)
            {
                return;
            }

            Console.Write($" {root.Data} ");
            PreOrderBinaryNode(root.Left);
            PreOrderBinaryNode(root.Right);

        }

        //InOrder (left, data, right)
        public void InOrderBinaryNode(BinaryNode? root)
        {
            if(root == null)
            {
                return;
            }

            InOrderBinaryNode(root.Left);
            Console.Write($" {root.Data} ");
            InOrderBinaryNode(root.Right);
        }

        //PostOrder (left, right, data)
        public void PostOrderBinaryNode(BinaryNode? root)
        {
            if(root == null)
            {
                return;
            }

            PostOrderBinaryNode(root.Left);
            PostOrderBinaryNode(root.Right);
            Console.Write($" {root.Data} ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution ObjSol = new Solution();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Root 1 2 3 4 5 6 7 9 15
            BinaryNode root = ObjSol.CreateBinaryNode(1);

            //Child
            BinaryNode left_child = ObjSol.CreateBinaryNode(2);
            BinaryNode right_child = ObjSol.CreateBinaryNode(3);

            //Level Two
            root.Left = left_child;
            root.Right = right_child;

            //Level Three
            root.Left.Left = ObjSol.CreateBinaryNode(4);
            root.Left.Right = ObjSol.CreateBinaryNode(5);
            root.Right.Left = ObjSol.CreateBinaryNode(6);
            root.Right.Right = ObjSol.CreateBinaryNode(7);

            //Level Four
            root.Left.Right.Left = ObjSol.CreateBinaryNode(9);
            root.Right.Right.Left = ObjSol.CreateBinaryNode(15);

            Console.WriteLine("PreOrder Depth First Search: ");
            ObjSol.PreOrderBinaryNode(root);
            Console.WriteLine();

            Console.WriteLine("InOrder Depth First Search: ");
            ObjSol.InOrderBinaryNode(root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Depth First Search: ");
            ObjSol.PostOrderBinaryNode(root);
            Console.WriteLine();

            stopwatch.Stop();
            Console.WriteLine($"Execution Time: {stopwatch.Elapsed}");

        }
    }
}
