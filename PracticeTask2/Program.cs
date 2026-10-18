using System;

class Program
{
    static void Main(string[] args)
    {
        int distance = 1500;
        int time = 120;

        // Calculate speed (use double)
        double speed = (double)distance / time;

        // Calculate time for 2500 meters
        int newDistance = 2500;
        double newTime = newDistance / speed;

        Console.WriteLine($"Average speed: {speed} m/s");
        Console.WriteLine($"Time for 2500 meters: {newTime} seconds");
    }
}
