using System;

namespace RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = new int[] { 1, 2, 3 };
            test(arr);

            Console.ReadKey();
        }

        public static void test(int[] r)
        {

            r[0] = 5;
        }

    }
}
