using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program5
    {
        static void Main1()  //Print Count the All element of array 
        {
            int[][] arr =
            {
                new int[] {10, 45, 36, 25, 78}, 
                new int[] {25, 78, 96, 85},
                new int[] {96, 58}
            };
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                count += arr[i].Length;
            }
            Console.WriteLine(count);
        }
    }
}
