﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Multiplication table: ");

        for(int i=1; i<=10; i++)
        {
            int output = num * i;
            Console.WriteLine($"{num} * {i}={output}");
        }
        Console.ReadLine();
    }
}