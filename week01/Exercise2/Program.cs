using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Ask the user for their grade percentage.
        Console.Write("What is your grade percentage? ");

        // 2. Read the input as a string.
        string userInput = Console.ReadLine();

        // 3. Convert the string input into an integer.
        int grade = int.Parse(userInput);

        // 4. Create a variable to hold the letter grade.
        string letter = "";

        // 5. Determine the letter grade.
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // 6. Print the letter grade.
        Console.WriteLine($"Your letter grade is: {letter}");

        // 7. Check if the user passed.
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Don't worry, you can do better next time.");
        }
    }
}