using System;

class Program
{
    public static void Main(string[] args)
    {
        int n;
        int sum, max, min;
        sum = 0;
        max = int.MinValue;
        min = int.MaxValue;

        for (int i = 0; i < 5; i++)
        {
            n = int.Parse(Console.ReadLine());


            sum += n;

            if (n > max)
                max = n;
            if (n < min)
                min = n;


        }

        Console.WriteLine($"Sum : {sum}");
        Console.WriteLine($"Mean : {sum / 5}");
        Console.WriteLine($"Max : {max}");
        Console.WriteLine($"Min : {min}");



    }
}