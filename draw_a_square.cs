using System;
class Program
{
    public static void Main(string[] args)
    {
        int x, width;
        x = Convert.ToInt32(Console.ReadLine());
        width = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= width; i++)
        {
            for (int j = 1; j <= width; j++)
            {
                Console.Write(x);
            }

            Console.WriteLine();

        }

    }
}