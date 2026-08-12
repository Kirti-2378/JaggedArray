using System;

namespace Array
{
    internal class Program4
    {
        static void Main1() // Print array input by  put row value and column value user row and column
        {
            int[][] arr = new int[3][];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter size of row " + (i + 1) + ":");
                int n = Convert.ToInt32(Console.ReadLine());

                arr[i] = new int[n];

                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("Enter value for row " + (i + 1) + ", column " + (j + 1) + ":");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nJagged Array:");

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