
using System;

class Program
{
    static void Main(string[] args)
    {
        double value = 7.85;

        // Explicit conversion to int
        int intValue = (int)value;

        // Implicit conversion back to double
        double doubleValue = intValue;

        // Compare values
        Console.WriteLine($"Original value: {value}");
        Console.WriteLine($"Integer value: {intValue}");
        Console.WriteLine($"Converted back to double: {doubleValue}");
        Console.WriteLine($"Are values equal? {value == doubleValue}");
    }
}
