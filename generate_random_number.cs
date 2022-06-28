using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter range");
        int min = Convert.ToInt32(Console.ReadLine());
        int max = Convert.ToInt32(Console.ReadLine());

        Random rnd = new Random();
        Console.WriteLine(rnd.Next(min, max + 1));

    }
}