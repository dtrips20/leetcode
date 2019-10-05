/*
Given an array of integers, find if the array contains any duplicates.

Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.

Example 1:
=================================
Input: [1,2,3,1]
Output: true

Example 2:
================================
Input: [1,2,3,4]
Output: false

Example 3:
================================
Input: [1,1,1,3,3,4,3,2,4,2]
Output: true


*/

using System;
using System.Collections;
using System.Collections.Generic;

namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.ContainsDuplicate(new int[] { 1, 2, 3, 4, 5, 5 }));

        }


        public bool ContainsDuplicate(int[] nums)
        {
            bool result = false;
            Hashtable dup = new Hashtable();

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (!dup.Contains(nums[i]))
                {
                    dup.Add(nums[i], nums[i]);
                }
                else
                    return true;
            }
            return result;
        }
        
    }
}
