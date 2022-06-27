using System;

class Program{
    public static void Main(String[] args){
       
       int res=1, num;
       for(int i =0; i<3;i++){
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            res*=num;
       }

       Console.WriteLine($"The multiplication of three numbers is {res}");
    }
}