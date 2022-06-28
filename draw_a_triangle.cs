/*
Write a program in C# that asks for a symbol and a width to paint a triangle of that width and height using that number to draw it.
*/

using System;
class Program
{
    public static void Main(string[] args)
    {
        int x, width;
        x = Convert.ToInt32(Console.ReadLine());
        width = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= width; i++)
        {
            for (int j = 1; j <= width - i + 1; j++)
            {
                Console.Write(x);
            }

            Console.WriteLine();

        }

    }
}