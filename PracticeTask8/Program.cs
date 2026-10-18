
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine() ?? "");

        // Calculate age
        int age = 2026 - birthYear;

        // Print greeting and age
        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine($"Your age: {age}");

        // Print uppercase name
        Console.WriteLine($"Uppercase name: {name.ToUpper()}");

        // Print name length
        Console.WriteLine($"Name length: {name.Length}");
    }
}
