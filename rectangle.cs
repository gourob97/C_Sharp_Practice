using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter height of the rectangle: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter width of the rectangle: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double perimeter = 2 * (a + b);
        double area = a * b;
        double diagonal = Math.Sqrt(a * a + b * b);

        Console.WriteLine($"Perimeter : {perimeter}");
        Console.WriteLine($"Area : {area}");
        Console.WriteLine($"Diagonal : {diagonal}");



    }
}