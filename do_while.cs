using System;

class Program
{
    public static void Main(string[] args)
    {
        int num;

        do
        {
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num * 10);
        } while (num != 0);
    }
}