using System;

class Program
{
    static void Main(string[] args)
    {
        double celsius = 25.0;

        // Convert to Fahrenheit
        double fahrenheit = celsius * 9 / 5 + 32;

        Console.WriteLine($"Celsius: {celsius}");
        Console.WriteLine($"Fahrenheit: {fahrenheit}");
    }
}