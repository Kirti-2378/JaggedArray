using System;

namespace JaggedArray
{
    internal class FileName2
    {
        static void Main1()
        {
            int[][] arr =
            {
                new int[] { 1, 2, 3, 4, 5, 7 },
                new int[] { 10, 20, 30 }
            };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}