/*
 * 
Merge Sorted Array
====================================

Solution
Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.

Note:
The number of elements initialized in nums1 and nums2 are m and n respectively.
You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2.

Example:
===============================================
Input:
nums1 = [1,2,3,0,0,0], m = 3
nums2 = [2,5,6],       n = 3
Output: [1,2,2,3,5,6]


 */

using System;

namespace MergeTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program p = new Program();

            p.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);

        }


        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int arraySize = m + n;
            int[] arr = new int[arraySize];
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < m && j < n)
            {
                if (nums1[i] <= nums2[j])
                {
                    arr[k++] = nums1[i++];

                }
                else

                {
                    arr[k++] = nums2[j++];
                }

            }

            while (i < m)
            {
                arr[k++] = nums1[i++];
            }


            while (j < n)
            {
                arr[k++] = nums2[j++];
            }

            //since we have put everything in num1 becuase it can hold all the elements of num1 + num2.
            for (i = 0; i <= nums1.Length - 1; i++)
            {
                nums1[i] = arr[i];
            }
        }
    }
}
