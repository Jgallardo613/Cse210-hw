using System;

class Program
{
    // Function 1: Displays the welcome message.
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function 2: Prompts for and returns the user's name.
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    // Function 3: Prompts for and returns the user's favorite number.
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        return number;
    }

    // Function 4: Accepts a number and returns its square.
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    // Function 5: Displays the final result.
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }

    static void Main(string[] args)
    {
        // Call each function in the correct order.
        DisplayWelcome();

        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        int squaredResult = SquareNumber(favoriteNumber);

        DisplayResult(name, squaredResult);
    }
}
