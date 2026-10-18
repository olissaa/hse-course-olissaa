using System;

class Program
{
    static void Main(string[] args)
    {
        double value = 3.99;

        int intValue = (int)value;
        Console.WriteLine($"Integer: {intValue}");

        double doubleValue = (double)intValue;
        Console.WriteLine($"Double: {doubleValue}");
    }
}