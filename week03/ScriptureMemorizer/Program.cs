using System;

class Program
{
    static void Main(string[] args)
    {
        // Define a scripture to be memorized.
        // You can change the book, chapter, and verse(s) here.
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        // Create a new Scripture object with the reference and text.
        Scripture scripture = new Scripture(reference, text);

        // Start the main loop. It will continue as long as not all words are hidden.
        while (!scripture.IsCompletelyHidden())
        {
            // Clear the console screen for a clean display.
            Console.Clear();

            // Display the scripture, including the reference and the text with hidden words.
            Console.WriteLine(scripture.GetDisplayText());

            // Prompt the user for input.
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            // Check if the user wants to quit.
            if (userInput.ToLower() == "quit")
            {
                break; // Exit the loop and end the program.
            }

            // Hide a few random words if the user presses Enter.
            scripture.HideRandomWords(3);
        }

        // Final display when the loop ends (all words are hidden or user quits).
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. The program has ended.");
    }
}