/*
Write a program in C# that asks the user for two numbers and one operation (+, -, x, /) then calculate the operation and display the result on the screen.

Show the text Unrecognized character if the operation symbol is different from the previous ones.

You should use the if block.
*/


using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first number : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter operation [+, -, *, /] : ");
        char op = Convert.ToChar(Console.ReadLine());
        Console.Write("Enter second number : ");
        int b = int.Parse(Console.ReadLine());

        if (op == '+')
        {
            Console.WriteLine($"Result: {a + b} ");
        }
        else if (op == '-')
        {
            Console.WriteLine($"Result: {a - b} ");
        }
        else if (op == '*')
        {
            Console.WriteLine($"Result: {a * b} ");
        }
        else if (op == '/')
        {
            Console.WriteLine($"Result: {a / b} ");
        }
        else
        {
            Console.WriteLine("Invalid Opeartion");
        }



    }
}