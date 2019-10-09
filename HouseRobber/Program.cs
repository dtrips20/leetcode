/*
House Robber
=========================================
You are a professional robber planning to rob houses along a street.
Each house has a certain amount of money stashed, the only constraint stopping you
from robbing each of them is that adjacent houses have security system connected 
and it will automatically contact the police if two adjacent houses were broken into on the same night.

Given a list of non-negative integers representing the amount of money of each house, 
determine the maximum amount of money you can rob tonight without alerting the police.

Example 1:
===============================
Input: [1,2,3,1]
Output: 4
Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
             Total amount you can rob = 1 + 3 = 4.

Example 2:
================================
Input: [2,7,9,3,1]
Output: 12
Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
             Total amount you can rob = 2 + 9 + 1 = 12.
 
*/

using System;

namespace HouseRobber
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
           
            Console.WriteLine(p.Rob(new int[] { 2,1,1,2}));
        }


        public int Rob(int[] nums)
        {
            int[] mem = new int[nums.Length];

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                mem[i] = -1;
            }
            return Rob(mem,nums, nums.Length - 1);
           
            
        }
        //Test case to check Dynamic programming.
        //[0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]

        // fi = max( [i-2]+num[i] , [i-1])
        // we cannot add num[i] to [i-1] becuase as per the problem that could trigger the alarm.
        // with dynamic programming
        public int Rob(int[] mem, int[] num, int i)
        {
            if (i < 0)
                return 0;

            if (mem[i] > -1)
                return mem[i];

            int max = Math.Max(Rob(mem, num, i-2) + num[i], Rob(mem, num, i - 1));
            mem[i] = max;
            return max;
        }
        /*
        private int Rob(int[] nums, int i)
        {
            int c = 0;
            int d = 0;
            if (i < 0)
                return 0;

            else
                c = Rob(nums, i - 2) + nums[i];
                d =  Rob(nums, i - 1);
                Console.WriteLine("c :"+c+" D :"+d);
            return Math.Max(c,d);
        }
          */
    }
}
