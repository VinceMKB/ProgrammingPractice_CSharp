using System;

namespace SwapPairs
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            // Dummy node acts as the prev node for the head node
            ListNode dummy = new ListNode(-1);
            dummy.next = head;
            ListNode prev = dummy;

            while (head!= null && head.next!= null)
            {
                // Nodes to be swapped
                ListNode first = head;
                ListNode second = head.next;

                // Swapping
                prev.next = second;
                first.next = second.next;
                second.next = first;

                // Reinitializing the head and prev for next swap
                prev = first;
                head = first.next;
            }

            // Return the new head node.
            return dummy.next;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);

            ListNode result = solution.SwapPairs(head);
            while (result!= null)
            {
                Console.Write(result.val + "->");
                result = result.next;
            }
        }
    }
}
