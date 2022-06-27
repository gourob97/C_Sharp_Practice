using Internal;
using System;

class Program{
    public static void Main(String[] args){
       Console.WriteLine("Enter dividend ");
       int num = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter divisor ");
       int  div = Convert.ToInt32(Console.ReadLine());

       try{
         Console.WriteLine($"The answer is  {num/div}");
       }

        catch(DivideByZeroException ex){
                Console.WriteLine("Can't Divide by Zero. {0}", ex.Message);
        }


       
    }
}