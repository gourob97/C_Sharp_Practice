using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter radius of the circel");
        double radius = Convert.ToDouble(Console.ReadLine());
        double surface = 4 * 3.1416 * radius * radius;
        double volume = (4 / 3.0) * 3.1416 * radius * radius * radius;

        Console.WriteLine($"Surface : {surface}");
        Console.WriteLine($"Volume : {volume}");



    }
}