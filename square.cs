using System;

class Program{
    public static void Main(string[] args){
       Console.WriteLine("Enter a number");
       int num = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("{0} * {0} = {1}", num, num*num);
    }
}