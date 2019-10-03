/*
Write a function to delete a node (except the tail) in a singly linked list, given only access to that node.

Example 1:
=====================================================
Input: head = [4,5,1,9], node = 5
Output: [4,1,9]
Explanation: You are given the second node with value 5, the linked list should become 4 -> 1 -> 9 after calling your function.


Example 2:
====================================================
Input: head = [4,5,1,9], node = 1
Output: [4,5,9]
Explanation: You are given the third node with value 1, the linked list should become 4 -> 5 -> 9 after calling your function.
 

Note:
====================================================
The linked list will have at least two elements.
All of the nodes' values will be unique.
The given node will not be the tail and it will always be a valid node of the linked list.
Do not return anything from your function.

*/

using System;

namespace DeleteNodeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0;
            ListNode head = null;
            ListNode temp = null;

            while (i < numbers.Length)
            {
               if (temp == null)
                {
                    temp = new ListNode(numbers[i]);
                    head = temp;
                }
                else
                {
                    while (temp != null && temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = new ListNode(numbers[i]);
                }
                i++;
            }
        }

        public void DeleteNode(ListNode node , int nodeNumberToDelete)
        {
              

          

        }
    }
      
 // Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }
}
