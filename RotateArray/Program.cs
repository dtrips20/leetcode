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
