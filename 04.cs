using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the value of N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Fibonacci terms: ");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(Fib(i) + " ");
        }
        Console.ReadLine();

        static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
    }
}
