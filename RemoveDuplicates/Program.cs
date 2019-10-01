using System;

/* 
 <summary>
    Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.
    Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
 </summary>
 */
namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 1, 2 };

            Program p = new Program();

            int ans = p.RemoveDuplicates(arr);

            


            Console.WriteLine(ans);
        }



        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            
            int changed = 0;
            for (int i = 1; i <= nums.Length - 1; i++)
            {
                if (nums[changed] != nums[i])
                {

                    changed++;
                    nums[changed] = nums[i];

                }

            }

            return changed+1;


        }
    }
}
