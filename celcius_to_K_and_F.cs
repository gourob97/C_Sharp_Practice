using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter celcius temperature: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double k = c + 273;
        double f = (9 * c / 5) + 32;

        Console.WriteLine($"Kelvin : {k}");
        Console.WriteLine($"Farenheit : {f}");


    }
}