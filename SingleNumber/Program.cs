/*
 
Given a non-empty array of integers, every element appears twice except for one. Find that single one.

Note: Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

Example 1:
========================
Input: [2,2,1]
Output: 1

Example 2:
========================
Input: [4,1,2,1,2]
Output: 4

 */
using System;

namespace SingleNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            int ans = p.SingleNumber(new int[] { 2, 2, 1 });
            Console.WriteLine(ans);
            

        }


        /// <summary>
        /// This is implemented using XOR
        /// a XOR a = 0
        /// a XOR 0 = a
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            int result = 0;

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                result = result ^ nums[i];

            }

            return result;


        }
    }
}
