using Internal;
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(@"Choose operation [1-5]
        1. Add
        2. Subtract
        3. Multiply
        4. Divide
        5. Mod
        ");


        Console.Write("Choose operation : ");

        int choice, a, b;
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice < 1 || choice > 5)
        {

            Console.WriteLine("Invalid choice");
            return;
        }

        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());





        switch (choice)
        {
            case 1:
                Console.WriteLine(a + b);
                break;

            case 2:
                Console.WriteLine(a - b);
                break;

            case 3:
                Console.WriteLine(a * b);
                break;

            case 4:
                Console.WriteLine(a / b);
                break;

            case 5:
                Console.WriteLine(a % b);
                break;


        }
    }
}