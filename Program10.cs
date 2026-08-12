using System;

class Program10
{
    static void Main()
    {
        int[][] arr =
        {
            new int[] { 1, 2 },
            new int[] { 3, 4, 5 },
            new int[] { 6, 7, 8, 9 }
        };

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(
                "Row " + (i + 1) + " = " + arr[i].Length + " elements");
        }
    }
}