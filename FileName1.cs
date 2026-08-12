using System;

class Program1
{
    static void Main1(string[] args)
    {
        int[][] arr =
        {
            new int[] { 10, 20, 30 },
            new int[] { 40, 50 },
            new int[] { 60, 70, 80, 90 }
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