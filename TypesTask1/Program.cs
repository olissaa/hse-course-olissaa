using System;

class Program
{
    static void Main(string[] args)
    {
        int lives = 3;
        float speed = 5.5f;
        string levelName = "Forest";

        float x = 10.5f;
        float y = 20.0f;
        float z = 3.5f;

        float loadingTime = 2.5f;

        Console.WriteLine($"Lives: {lives}");
        Console.WriteLine($"Speed: {speed}");
        Console.WriteLine($"Level: {levelName}");
        Console.WriteLine($"Camera: ({x}, {y}, {z})");
        Console.WriteLine($"Loading time: {loadingTime} seconds");
    }
}