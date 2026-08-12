using System;

class Program2
{
    static void Main1()  // Reverse array column and row
    {
        int[][] arr =
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5 },
            new int[] { 6, 7, 8, 9 }
        };

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = arr[i].Length - 1; j >= 0; j--)
            {
                Console.Write(arr[i][j] + " ");
            }

            Console.WriteLine();
        }
    }
}