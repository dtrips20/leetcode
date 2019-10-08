/*
First Bad Version
====================
You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.

Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.

You are given an API bool isBadVersion(version) which will return whether version is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API.

Example:
=========================================================
Given n = 5, and version = 4 is the first bad version.

call isBadVersion(3) -> false
call isBadVersion(5) -> true
call isBadVersion(4) -> true

Then 4 is the first bad version. 
 
=============================================================================
 The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); 
=============================================================================     
       
 */



using System;

namespace FirstBadVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        public int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            //I tried to set mid = n initially because I think whatif the last version is bad. 
            //however you can also try mid = left + ( right-left) /2;
            int mid = n;

            while (left < right)
            {
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
                mid = left + (right - left) / 2;
            }
            return left;
        }

        public static bool IsBadVersion(int version)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 10);

            if (version == randomNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
