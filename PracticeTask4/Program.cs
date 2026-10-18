
using System;

class Program
{
    static void Main(string[] args)
    {
        string modelName = "Dancing Robot";
        int polygons = 5000;
        float animationDuration = 12.5f;
        bool isVisible = true;
        float rotationAngle = 90.0f;

        Console.WriteLine($"Model name: {modelName}");
        Console.WriteLine($"Polygons: {polygons}");
        Console.WriteLine($"Animation duration: {animationDuration} seconds");
        Console.WriteLine($"Visible: {isVisible}");
        Console.WriteLine($"Rotation angle: {rotationAngle} degrees");
    }
}
