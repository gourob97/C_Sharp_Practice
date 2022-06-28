/*
Write a program in C # that requests a width and shows a northeast triangle.

Use the * character to paint the triangle.
*/


using System;

class Program
{
    public static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());

        for (int i = 0; i < width; i++)
        {

            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < width - i; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }


    }
}
