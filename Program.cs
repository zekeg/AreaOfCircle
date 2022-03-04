using System;

namespace AreaOfCircle; 

internal class AreaOfCircle
{
    public static double FindAreaOfCircle(double radius) {
        Console.WriteLine("hello");
        return Math.PI * radius * radius;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("What is the area of your circle?");
        var radius = double.Parse(Console.ReadLine());
        Console.WriteLine($"The area of a circle with radius {radius} is {FindAreaOfCircle(radius)}");
    }
}
