//Write a program in C# that asks the user for a string and displays a right-aligned triangle.

using System;

class Program
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int length = name.Length;
        Console.WriteLine(length);

        for (int i = 1; i <= length; i++)
        {
            Console.WriteLine(name.Substring(length - i, i));
        }

    }
}
