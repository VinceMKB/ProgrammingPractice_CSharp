using System;
using RemoveDupSortedList;

namespace RemoveDupSortedList
{
    public class ListNode
    {
        public int value;
        public ListNode? next;
        public ListNode(int value = 0, ListNode? next =  null)
        {
            this.value = value;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode current = head;
            while(current.next != null)
            {
                if(current.value == current.next.value)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return head;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListNode node_one = new ListNode(1, null);
            ListNode node_two = new ListNode(1, node_one);
            ListNode node_three = new ListNode(2, node_two);
            ListNode node_four = new ListNode(3, node_three);
            ListNode node_five = new ListNode(4, node_four);
            ListNode node_six =  new ListNode(4, node_five);

            ListNode head = node_six;

            Solution ObjSol = new Solution();
            
            ListNode result = ObjSol.DeleteDuplicates(head);

            ListNode current = result;
            while(current != null)
            {
                Console.Write(current.value + "->");
                current = current.next;
            }

            Console.WriteLine("null");


        }
    }
}
