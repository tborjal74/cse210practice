using System;
using System.Formats.Asn1;
using System.Reflection.PortableExecutable;

class Program
{

    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 10);
        int guessNumber = 0;
        string answer = "";
        int guessCount = 0;

        do
        {
            Console.WriteLine("What is your guess?:");
            guessNumber = int.Parse(Console.ReadLine());
            guessCount++;

            if (guessNumber < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {guessCount} guesses.");
                Console.WriteLine("Woud you like to play again? (y/n)");
                answer = Console.ReadLine();

                if (answer == "n" || answer == "N")
                {
                    Console.WriteLine("Thank you for playing!");
                    break;
                }
            }

        } while (answer != "Y" || answer != "y");
    }
}