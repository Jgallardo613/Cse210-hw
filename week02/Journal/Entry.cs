using System;

public class Entry
{
    // These are the properties (data) for a single entry.
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    // This method displays the entry's contents.
    public void Display()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {PromptText}");
        Console.WriteLine($"{EntryText}");
    }
}