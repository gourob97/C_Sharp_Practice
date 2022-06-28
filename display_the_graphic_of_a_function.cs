//Create a program C# to draw the graphic of the function y=(x-4)² for a range of integer values of x requested from the user.

using System;
class Program
{
    public static void Main(string[] args)
    {

        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());


        for (int i = min; i <= max; i++)
        {
            int count = (i - 4) * (i - 4);


            if (count != 0)
            {
                while (count != 0)
                {
                    Console.Write("*");
                    count--;
                }
                Console.WriteLine();

            }
        }



    }
}
