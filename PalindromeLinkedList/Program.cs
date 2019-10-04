using Nodes;
using System;
using System.Collections.Generic;

namespace PalindromeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2};
           

            ListNode dummy = new ListNode(0);
            ListNode head = dummy;
            int counter = 0;
            while (counter <= numbers.Length - 1)
            {
               
                ListNode node = new ListNode(numbers[counter]);
                dummy.next = node;
                dummy = dummy.next;
                counter++;
            }

            head = head.next;

            Program p = new Program();
            Console.WriteLine(p.IsPalindrome(head));
         
        }


        public bool IsPalindrome(ListNode head)
        {

            ListNode prev = null;
            ListNode curr = null;
            int cnt = 0;
            List<int> objs = new List<int>();

            while (head != null)
            {
                objs.Add(head.val);
                curr = head.next;
                head.next = prev;
                prev = head;
                head = curr;
            }

            head = prev;
          
            while (head != null)
            {
                if (objs[cnt] != head.val)
                {
                  
                    return false;
                }

                head = head.next;
                cnt++;
            }
            return true;
        }
    }
}
