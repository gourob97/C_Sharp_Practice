using System;

class Program
{
    public static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());

        while (x != 0)
        {
            Console.WriteLine(x * 10);
            x = int.Parse(Console.ReadLine());

        }

    }
}