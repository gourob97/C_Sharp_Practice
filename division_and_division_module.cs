using Internal;
using System;

class Program{
    public static void Main(String[] args){
       Console.WriteLine("Enter dividend ");
       int num = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter divisor ");
       int  div = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine($"The quotient is {num/div}");
       Console.WriteLine($"The remainder is {num%div}");

       
    }
}