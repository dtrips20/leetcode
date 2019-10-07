/*
 * Simple Merge sort 
 * 
 */
using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {

            Program P = new Program();
            int[] arr = { 12, 11, 3, 6, 1, 9 };
            P.sort(arr, 0, arr.Length - 1);

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }



        public void sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int midPoint = (left + right) / 2;
                sort(arr, left, midPoint);
                sort(arr, midPoint + 1, right);
                Merge(arr, left, midPoint, right);
        }
        }

        public void Merge(int[] arr, int left, int mid, int right)
        {
            // add +1 to the equation becuase the size should be greated than 1 
            // example : left = 0 and mid = 0 then we need to add 1 to make the size greater than 1
            int sizeOfLeftArray = mid - left +1 ;
            int sizeOfRightArray = right - mid;

            int[] leftArray = new int[sizeOfLeftArray];
            int[] rightArray = new int[sizeOfRightArray];

            for (int i = 0; i < sizeOfLeftArray; i++)
            {
                leftArray[i] = arr[left + i];
            }

            for (int j = 0; j < sizeOfRightArray; j++)
            {
                rightArray[j] = arr[mid +j+1];

            }

            int leftCounter = 0;
            int rightCounter = 0;
            //remember to set main array counter starting the left hand side otherwise everytime it will start with 0
            int mainArrayCounter = left;

            while (leftCounter < sizeOfLeftArray && rightCounter < sizeOfRightArray)
            {
                if (leftArray[leftCounter] <= rightArray[rightCounter])
                {
                    arr[mainArrayCounter++] = leftArray[leftCounter++];
                }
                else
                {
                    arr[mainArrayCounter++] = rightArray[rightCounter++];
                }
            }

            while (leftCounter < sizeOfLeftArray)
                
            {
                arr[mainArrayCounter++] = leftArray[leftCounter++];
                
            }


            while (rightCounter < sizeOfRightArray)

            {
                arr[mainArrayCounter++] = rightArray[rightCounter++];
            }
        }
    }

  

}
