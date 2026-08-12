using System;

namespace ConsoleApp1
{
    internal class Program_4
    {
        static void Main4(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " X " + i + " = " + (n * i));
            }
        }
    }
}