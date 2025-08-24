using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your grade percentage?");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

            string letter = "";
            bool passed = false;
            string plusSign = "+";
            string minusSign  = "-";

        if (grade >= 90)
        {
            letter = "A";
            passed = true;
        }
        else if (grade >= 80)
        {
            letter = "B";
            passed = true;
        }
        else if (grade >= 70)
        {
            letter = "C";
            passed = true;
        }
        else if (grade >= 60)
        {
            letter = "D";
            passed = false;
        }
        else
        {
            letter = "F";
            passed = false;
        }
        

        if (grade % 10 >= 7 && grade >= 60)
        {
            letter += plusSign;
            Console.WriteLine($"Your letter grade is {letter}.");
        }

        else if (grade % 10 <= 3 && grade >= 60 && grade <= 93)
        {
            letter += minusSign;
            Console.WriteLine($"Your letter grade is {letter}.");
        }


        if (grade >= 94)
        {
            Console.WriteLine($"Your letter grade is A.");
        }
         if (grade < 60)
        {
            Console.WriteLine($"Your letter grade is F.");
         }
       

            if (passed)
        {
            Console.WriteLine("You passed the course.");
        }
        else
        {
            Console.WriteLine("You failed the course.");
        }
    }
}