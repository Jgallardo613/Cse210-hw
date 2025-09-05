using System;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Generate a random magic number.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1; // Initialize the guess variable to something that won't match the magic number.

        // Part 2: Loop until the user guesses the magic number.
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

            // Use an if statement to compare the guess and the magic number.
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}