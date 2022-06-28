using System;

class Program
{
    public static void Main(string[] args)
    {
        int num, sum = 0;

        num = int.Parse(Console.ReadLine());

        if (num == 0)
        {
            Console.WriteLine($"Sum : {sum}");
            return;
        }

        sum = num;

        while (num != 0)
        {

            Console.WriteLine($"Sum : {sum}");
            num = int.Parse(Console.ReadLine());
            sum += num;

        }
        Console.WriteLine("Finished");






    }
}