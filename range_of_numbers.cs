using System;

class Program
{
    public static void Main(string[] args)
    {
        int min, max;
        min = int.Parse(Console.ReadLine());
        max = int.Parse(Console.ReadLine());

        for (int i = min; i <= max; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();



    }
}