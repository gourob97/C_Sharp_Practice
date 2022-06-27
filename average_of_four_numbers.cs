using System;

class Program{
    public static void Main(string[] args){
        int a,b,c,d;

        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        d = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The multiplication of three numbers is {(a+b+c+d)/4}");
    }
}