using Internal;
using System;

class Program{
    public static void Main(String[] args){
       
       int x;
       Console.WriteLine("Enter a number");
       x= Convert.ToInt32(Console.ReadLine());

       Console.WriteLine(-6 + x * 5);
        Console.WriteLine( (13-2) * x );
        Console.WriteLine( (x + -2) * (20 / 10) );
        Console.WriteLine( (12 + x) / (5 - 4) );

    }
}