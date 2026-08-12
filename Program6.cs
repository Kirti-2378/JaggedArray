using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program6
    {
        static void Main1()      // Print Even Number of the array
        {
            int[][] arr =
            {
                new int[] {10, 85, 96, 48, 52},
                new int[] {78, 96, 56, 23, 21},
                new int[] {20, 21, 41, 75}
            };
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] % 2 == 0)
                    {
                        Console.WriteLine(arr[i][j]);
                    }
                }
            }
        }
    }
}
