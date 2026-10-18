
using System;

class Program
{
    static void Main(string[] args)
    {
        string data = "x=10;y=20;z=30";

        string[] coordinates = data.Split(';');

        string[] x = coordinates[0].Split('=');
        string[] y = coordinates[1].Split('=');
        string[] z = coordinates[2].Split('=');

        Console.WriteLine($"Coordinate {x[0]} = {x[1]}");
        Console.WriteLine($"Coordinate {y[0]} = {y[1]}");
        Console.WriteLine($"Coordinate {z[0]} = {z[1]}");
    }
}
