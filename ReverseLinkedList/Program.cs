/*
Reverse a singly linked list.

Example:
================================
Input: 1->2->3->4->5->NULL
Output: 5->4->3->2->1->NULL

*/

using System;
using Nodes;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            int[] nodes = { 1, 2, 3, 4, 5 };

            ListNode dummy = new ListNode(0);
            ListNode head = dummy;

            for (int i = 0; i <= nodes.Length - 1; i++)
            {
                ListNode node = new ListNode(nodes[i]);
                dummy.next = node;
                dummy = dummy.next;
            }
            head = head.next;

            ListNode rList = p.ReverseList(head);
        }

        public ListNode ReverseList(ListNode head)
        {

            ListNode prev = null;
            ListNode curr = null;

            while (head != null)
            {
                curr = head.next;
                head.next = prev;
                prev = head;
                head = curr;
            }

            return prev;

        }
    }
}

/*
27 / 27 test cases passed.
Status: Accepted
Runtime: 92 ms
Memory Usage: 23.6 MB
*/
