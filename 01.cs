﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double Area = CalculateArea(width, height);
        Console.WriteLine($"The area of the reactangle is: {Area}");

        Console.ReadLine();

        static double CalculateArea(double width, double height)
        {
            return (width * height);
        }
    }
}