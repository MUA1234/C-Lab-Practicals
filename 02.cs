using System;

class Program
{
    static void Main(string[] args) {
        int i;
        for (i = 1; i <= 10; i++)
        {
            Console.Write("Enter number" + " " + i + ":");

            int number = Convert.ToInt32(Console.ReadLine());

            if (IsEven(number)) 
            {
                Console.WriteLine($"{number} is even");
            }
    else
            {
                Console.WriteLine($"{number} is odd");
            }
        }
        Console.ReadLine();

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

    }
}