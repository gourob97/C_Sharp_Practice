/*

Create a program C# to ask the user for a distance in meters and the time taken (hours, minutes, seconds).

Display the speed, in meters per second, kilometers per hour and miles per hour.

*/


using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter distance covered [in meters]: ");
        float dist = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Enter required time:");
        Console.Write("Hours : ");
        float hr = Convert.ToSingle(Console.ReadLine());

        Console.Write("Minutes : ");
        float min = Convert.ToSingle(Console.ReadLine());

        Console.Write("Seconds : ");
        float sec = Convert.ToSingle(Console.ReadLine());


        float total_sec = (hr * 60 * 60) + (min * 60) + sec;
        float total_hr = hr + (min / 60) + (sec / 3600);

        float speed_mps = dist / total_sec;
        float speed_kmphr = (dist / 1000) / total_hr;
        float mph = (dist / 1609) / total_hr;



        Console.WriteLine($"Speed [meter per second] : {speed_mps}");
        Console.WriteLine($"Speed [kilometer per hour] : {speed_kmphr}");
        Console.WriteLine($"Speed [miles per hour] : {mph}");



    }
}