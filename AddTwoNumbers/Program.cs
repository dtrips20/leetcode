using System;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            ListNode l1 = null;
            ListNode header1 = null;


            ListNode l2 = null;
            ListNode header2 = null;

            int[] x = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            int[] y = { 5, 6, 4 };
  

            for (int i = 0; i <= x.Length-1; i++)
            {

                if (header1 == null)
                {
                    header1 = new ListNode(x[i]);
                    l1 = header1;
                }
                else
                {
                    while (header1.next != null)
                    {
                        header1 = header1.next;
                    }
                    header1.next = new ListNode(x[i]);
                }
              
            }


            for (int i = 0; i <= y.Length-1; i++)
            {

                if (header2 == null)
                {
                    header2 = new ListNode(y[i]);
                    l2 = header2;
                }
                else
                {
                    while (header2.next != null)
                    {
                        header2 = header2.next;
                    }
                    header2.next = new ListNode(y[i]);
                }

            }

                           
         

            Program p = new Program();
            p.AddTwoNumbers(l1, l2);

            Console.ReadKey();
        }


        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = l1;

            double x1 = 1;
            double c1 = 0;

            while (head != null)
            {

                c1 = c1 + head.val * x1;
                x1 = x1 * 10;
                head = head.next;
            }


            head = l2;

            double x2 = 1;
            double c2 = 0;

            while (head != null)
            {

                c2 = c2 + head.val * x2;
                x2 = x2 * 10;
                head = head.next;
            }

            double total = c1 + c2;

            if (total == 0)
                return new ListNode(0);

            ListNode n1 = null;
            ListNode ret = null;
            ListNode header = null;

            int num = 0;
            
            while (total != 0)
            {
                num = Convert.ToInt32 (total % 10);

               

                if (header == null)
                {
                    header = new ListNode(num);
                    ret = header;

                }
                else
                {

                    while (header.next != null)
                    {
                        header = header.next;
                    }

                    header.next = new ListNode(num);
                }

                total = (total-num ) / 10;

            }












            return ret;


        }

    }
  
  public class ListNode
   {
      public double val;
      public ListNode next;
      public ListNode(double x) { val = x; }
  }
 
}
