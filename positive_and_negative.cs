using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number : ");
        int x = int.Parse(Console.ReadLine());
        if (x < 0)
        {
            Console.WriteLine("Negative!");
        }
        else
        {
            Console.WriteLine("Positive");
        }
    }
}