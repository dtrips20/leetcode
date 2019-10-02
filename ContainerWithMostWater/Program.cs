using System;
/*
 * Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai).
 * n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). 
 * Find two lines, which together with x-axis forms a container, such that the container contains the most water.

Note: You may not slant the container and n is at least 2.

    
Example Image : https://s3-lc-upload.s3.amazonaws.com/uploads/2018/07/17/question_11.jpg

Example
===============================
Input: [1,8,6,2,5,4,8,3,7]
Output: 49
 */
namespace ContainerWithMostWater
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] waterLevel = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Console.WriteLine(p.MaxArea(waterLevel));
        }


        public int MaxArea(int[] height)
        {
            int start = 0;
            int end = height.Length-1;
            int maxArea = 0;
            int area = 0;

            while (start < end)
            {
                int length = end - start;
                if (height[start] < height[end])
                {
                   
                    area = height[start] * length;
                    start++;


                }
                else
                {
                 
                    area = height[end] * length;
                    end--;
                }

                maxArea = Math.Max(maxArea, area);


            }

            return maxArea;
        }
    }
}

/*
 *  
50 / 50 test cases passed.
Status: Accepted
Runtime: 108 ms
Memory Usage: 26.9 MB
 * 
 * 
 */
