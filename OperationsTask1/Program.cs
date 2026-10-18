using System;

class Program
{
    static void Main(string[] args)
    {
        double x = 2.5;
        double y = 3.0;
        
        double dx = 1.5;
        double dy = -2.0;

        double newX = x + dx;
        double newY = y + dy;
        Console.WriteLine($"New point: ({newX}, {newY})");
    }
}