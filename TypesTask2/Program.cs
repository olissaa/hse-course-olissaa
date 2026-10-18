using System;

class Program
{
    static void Main(string[] args)
    {
        string objectName = "Cube";

        float x = 1.5f;
        float y = 2.0f;
        float z = 3.5f;

        float scale = 1.5f;
        float rotation = 45.0f;
        bool isVisible = true;

        Console.WriteLine($"Object: {objectName}");
        Console.WriteLine($"Coordinates: ({x}, {y}, {z})");
        Console.WriteLine($"Scale: {scale}");
        Console.WriteLine($"Rotation: {rotation} degrees");
        Console.WriteLine($"Visible: {isVisible}");
    }
}