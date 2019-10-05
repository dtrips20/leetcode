/*
Given an array, rotate the array to the right by k steps, where k is non-negative.

Example 1:
==========================================
Input: [1,2,3,4,5,6,7] and k = 3
Output: [5,6,7,1,2,3,4]

Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]

Example 2:
==========================================
Input: [-1,-100,3,99] and k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]

Author:Deepak Tripathi
Date  :10/04/2019
*/

using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;

            Program p = new Program();
            p.Rotate(numbers, k);

        }


        public void Rotate(int[] nums, int k)
        {

            k = k % nums.Length;

            this.Reverse(nums, 0, nums.Length - k - 1);
            this.Reverse(nums, nums.Length - k, nums.Length - 1);
            this.Reverse(nums, 0, nums.Length - 1);

        }

        private void Reverse(int[] nums, int start, int end)
        {
            int temp = 0;
            while (start < end)
            {
                temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }

        }
    }
}
