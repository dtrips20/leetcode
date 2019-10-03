/*
 Remove Nth Node From End of List
Given a linked list, remove the n-th node from the end of list and return its head.

Example:
========================
Given linked list: 1->2->3->4->5, and n = 2.

After removing the second node from the end, the linked list becomes 1->2->3->5.

Note:
============================
Given n will always be valid.

Follow up:
============================
Could you do this in one pass?
 */
using Nodes;
using System;

namespace RemoveNthNodeFromEndofList
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1,2,3,4,5 };
          
            ListNode dummy = new ListNode(0);
            ListNode head = dummy;

            for (int position = 0; position <= numbers.Length - 1; position++)
            {
                ListNode tempNode = new ListNode(numbers[position]);
                dummy.next = tempNode;
                dummy = dummy.next;
            }
            head = head.next;


            Program p = new Program();
            ListNode resultNode = p.RemoveNthFromEnd(head, 2);

        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            

           ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode firstPointer = dummy;
            ListNode secondPointer = dummy;

            for (int i = 1; i <= n + 1; i++)
            {
                firstPointer = firstPointer.next;
            }


            // Move first to the end, maintaining the gap
            while (firstPointer != null)
            {
                firstPointer = firstPointer.next;
                secondPointer = secondPointer.next;
            }
            secondPointer.next = secondPointer.next.next;
            return dummy.next;
        }

    }
}
