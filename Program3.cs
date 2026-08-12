using System;

namespace Array
{
    internal class Program3
    {
        static void Main1() // Print sum of all array element 
        {
            int[][] arr =
            {
                new int[] { 10, 20, 30 },
                new int[] { 40, 50 },
                new int[] { 60 }
            };

            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;

                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum += arr[i][j];
                }

                Console.WriteLine("Row " + (i + 1) + " Sum = " + sum);
            }
        }
    }
}