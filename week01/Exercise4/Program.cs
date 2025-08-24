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
                double largest = numbers.Max();
                Console.WriteLine($"The largest number is: {largest}");
                double smallPositve = numbers.Where(n => n > 0).Min();
                Console.WriteLine($"The smallest positive number is: {smallPositve}");
                Console.WriteLine("The sorted list is:");
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.WriteLine(numbers[i]);
                    numbers.Sort();
                }
            }

        } while (number != 0);
    }
}