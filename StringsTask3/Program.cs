using System;

class Program
{
    static void Main(string[] args)
    {
        string coords = "x=10;y=20;z=30";

        string[] parts = coords.Split(';');

        foreach (string part in parts)
        {
            string[] values = part.Split('=');
            Console.WriteLine(values[1]);
        }
    }
}
