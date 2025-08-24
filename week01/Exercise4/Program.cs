using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List <int> numbers = new List<int>(); 
        int number = -1;

        do
        {
            Console.WriteLine("Enter number:");
            string input = Console.ReadLine();
            number = int.Parse(input);
            numbers.Add(number);
            if (number == 0)
            {
                double sum = numbers.Sum();
                Console.WriteLine($"The sum is: {sum}");
                double average = numbers.Average();
                Console.WriteLine($"The average is: {average}");
            }

        } while (number != 0);
    }
}