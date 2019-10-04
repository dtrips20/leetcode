using System;
using Nodes;

namespace MergeTwoSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers1 = { 1, 2, 4 };

            ListNode dummy1 = new ListNode(0);
            ListNode head1 = dummy1;

            for (int i = 0; i <= numbers1.Length - 1; i++)
            {
                dummy1.next = new ListNode(numbers1[i]);
                dummy1 = dummy1.next;
            }

            head1 = head1.next;

            int[] numbers2 = { 1, 3, 4 };

            ListNode dummy2 = new ListNode(0);
            ListNode head2 = dummy2;

            for (int i = 0; i <= numbers2.Length - 1; i++)
            {
                dummy2.next = new ListNode(numbers2[i]);
                dummy2 = dummy2.next;
            }

            head2 = head2.next;

            Program p = new Program();
            ListNode returnNode = p.MergeTwoLists(head1, head2);

         
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {

            if (l1 == null) return l2;
            if (l2 == null) return l1;
            if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }





        }
                
    }
}
