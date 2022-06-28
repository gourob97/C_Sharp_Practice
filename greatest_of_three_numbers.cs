using System;

class Program
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());


        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine($"The greatest number is {a}");
            }
            else
            {
                Console.WriteLine($"The greatest number is {c}");
            }

        }
        else
        {
            if (b > c)
            {
                Console.WriteLine($"The greatest number is {b}");
            }
            else
            {
                Console.WriteLine($"The greatest number is {c}");
            }
        }
    }
}