using System;

class Program
{
    static void Main(string[] args)
    {
        float x = 2.5f, y = 3.0f, z = 1.5f;
        float dx = 1.5f, dy = -2.0f, dz = 0.5f;

        // Calculate new coordinates
        float newX = x + dx;
        float newY = y + dy;
        float newZ = z + dz;

        Console.WriteLine($"New position: ({newX}, {newY}, {newZ})");
    }
}