using System;

class Program
{
    static void Main(string[] args)
    {
        

        Console.Write("Enter a positive number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num >= 0) {

            int sum = CalculateSum(num);

            Console.WriteLine($"The sum is: {sum}");
        }
        else
        {
            Console.WriteLine("The number you entered is not positive");
        }
        Console.ReadLine();

        static int CalculateSum(int i)
        {
            return (i * (i + 1)) / 2;
        }
    }
}