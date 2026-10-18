using System;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "scene_01.unity";

        // Find dot position
        int dotPosition = fileName.IndexOf('.');

        Console.WriteLine($"File name: {fileName}");
        Console.WriteLine($"Dot position: {dotPosition}");
    }
}