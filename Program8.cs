using System;

class Program8
{
    static void Main1()
    {
        int[][] arr =
        {
            new int[] { 10, 20, 30 },
            new int[] { 40, 50 },
            new int[] { 60, 70, 80, 90 }
        };

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i][arr[i].Length - 1] + " ");
        }
    }
}