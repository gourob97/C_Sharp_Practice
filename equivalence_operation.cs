using System;

class Program{
    public static void Main(string[] args){
       
       int a,b,c;
       a = Convert.ToInt32(Console.ReadLine());
       b = Convert.ToInt32(Console.ReadLine());
       c = Convert.ToInt32(Console.ReadLine());


       Console.WriteLine((a+b)*c);
        Console.WriteLine( a * c + b*c);
    }
}