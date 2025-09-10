// W02 Project: Journal Program - Submission
//
// Exceeding Requirements: To go beyond the core requirements, I implemented error handling
// in the file I/O operations (saving and loading). Specifically, the SaveToFile method
// uses a try-catch block to handle potential issues with writing to the file, and the
// LoadFromFile method checks if the specified file exists before attempting to read from it.
// This makes the program more robust and user-friendly by preventing errors and
// providing helpful feedback to the user.
using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of God in my life today?",
            "What is one thing I am grateful for today?",
            "What was the strongest emotion I felt today?"
        };

        Random random = new Random();

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string randomPrompt = prompts[random.Next(prompts.Count)];
                    Console.WriteLine($"\nPrompt: {randomPrompt}");
                    
                    Entry newEntry = new Entry();
                    newEntry.Date = DateTime.Now.ToShortDateString();
                    newEntry.PromptText = randomPrompt;
                    Console.Write("Your entry: ");
                    newEntry.EntryText = Console.ReadLine();
                    
                    myJournal.AddEntry(newEntry);
                    break;
                case "2":
                    myJournal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter the filename to load: ");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadFromFile(loadFilename);
                    break;
                case "4":
                    Console.Write("Enter the filename to save: ");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveToFile(saveFilename);
                    break;
                case "5":
                    Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                    break;
            }
        }
    }
}