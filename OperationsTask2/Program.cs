using System;

class Program
{
    static void Main(string[] args)
    {
        double distance = 1500;

        double time = 120;

        double speed = distance / time;

        Console.WriteLine($"Average speed: {speed} m/s");
    }
}