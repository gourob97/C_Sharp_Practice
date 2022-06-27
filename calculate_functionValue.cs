using Internal;
using System;

class Program
{
    public static void Main(string[] args)
    {
        int start, end;

        start = Convert.ToInt32(Console.ReadLine());
        end = Convert.ToInt32(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            Console.Write("{0} ", (i * i - 2 * i + 1));

        }

        Console.WriteLine();

    }
}