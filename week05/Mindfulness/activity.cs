using System;
using System.Threading;
using System.Collections.Generic;

public class Activity
{
    private static Dictionary<string, int> _activityLog = new Dictionary<string, int>();

    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        if (!_activityLog.ContainsKey(_name))
        {
            _activityLog.Add(_name, 0);
        }
    }

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    protected void DisplayEndingMessage()
    {
        LogActivityCompletion();

        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    private void LogActivityCompletion()
    {
        _activityLog[_name]++;
    }

    public static void DisplayActivityLog()
    {
        Console.WriteLine("\n--- Session Activity Summary ---");
        foreach (var entry in _activityLog)
        {
            Console.WriteLine($"- {entry.Key}: Completed {entry.Value} time(s)");
        }
        Console.WriteLine("--------------------------------");
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (i >= 10)
            {
                Console.Write("\b \b");
            }
        }
    }
}