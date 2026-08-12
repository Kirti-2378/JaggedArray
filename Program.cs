using System;

class Program
{
    static void Run() // Print all array row and column
    {
        int[][] arr =
        {
            new int[] { 1, 2, 3 },
            new int[] { 10, 20 },
            new int[] { 100, 200, 300, 400 }
        };

        Console.WriteLine(arr[0][1]);

        Console.ReadKey();
    }
}