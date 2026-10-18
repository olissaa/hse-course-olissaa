
using System;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "level_01_scene.unity";

        // Find dot
        int dotIndex = fileName.IndexOf('.');

        // Extract name
        string name = fileName.Substring(0, dotIndex);

        // Convert to uppercase
        string upperName = name.ToUpper();

        Console.WriteLine($"File name: {upperName}");
    }
}
