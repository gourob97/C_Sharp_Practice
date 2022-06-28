//Write a program in C# that requests a number x and then displays a rectangle 3 columns wide and 5 rows high ////using that digit.

using System;

class Program
{
    public static void Main(string[] args)
    {
        int x;
        x = int.Parse(Console.ReadLine());

        for (int i = 0; i < 5; i++)
        {

            Console.WriteLine($"{x}{x}{x}");
        }
    }
}
