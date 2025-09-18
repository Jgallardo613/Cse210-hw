// Program.cs

using System;
using System.Collections.Generic;

// Exceeds Core Requirements:
// I have implemented a feature that allows the user to choose from a list of scriptures.
// The program presents a numbered list of scriptures, and the user's selection
// determines which one is used for the memorization exercise.

class Program
{
    static void Main(string[] args)
    {
        // Create a list of scriptures to choose from
        List<Scripture> scriptures = new List<Scripture>();

        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture1 = new Scripture(reference1, "Trust in the LORD with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        scriptures.Add(scripture1);

        Reference reference2 = new Reference("John", 3, 16);
        Scripture scripture2 = new Scripture(reference2, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        scriptures.Add(scripture2);

        Reference reference3 = new Reference("Mosiah", 3, 19);
        Scripture scripture3 = new Scripture(reference3, "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.");
        scriptures.Add(scripture3);
        
        // Let the user choose a scripture
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        Console.WriteLine("Please choose a scripture to memorize:");
        
        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {scriptures[i].GetDisplayText()}");
        }

        Console.Write("\nEnter the number of the scripture you want to study: ");
        string choice = Console.ReadLine();
        int index = int.Parse(choice) - 1;
        
        Scripture currentScripture = scriptures[index];

        string userInput = "";

        while (userInput != "quit" && !currentScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            userInput = Console.ReadLine();
            
            if (userInput != "quit")
            {
                // The fix is right here.
                // We're now passing an argument (3) to the method.
                currentScripture.HideRandomWords(3);
            }
        }
        
        Console.Clear();
        Console.WriteLine(currentScripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Program finished.");
    }
}