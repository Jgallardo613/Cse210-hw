using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
    }

    // New method to determine the user's title
    private string GetTitle()
    {
        if (_score >= 2000)
        {
            return "Master Questor";
        }
        else if (_score >= 500)
        {
            return "Apprentice Questor";
        }
        else
        {
            return "Novice Questor";
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select the type of Goal to create:");
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus points for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalDetails();

        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int pointsEarned = _goals[index].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points!");
            DisplayPlayerInfo();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals currently tracked.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    // Updated method to display the title
    public void DisplayPlayerInfo()
    {
        string title = GetTitle();
        Console.WriteLine($"\nYou are currently a {title}.");
        Console.WriteLine($"You have **{_score}** points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        
        _goals.Clear();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split("|");
                string goalType = parts[0];
                
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (goalType == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);
                    _goals.Add(new SimpleGoal(name, description, points, isComplete));
                }
                else if (goalType == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (goalType == "ChecklistGoal")
                {
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int completed = int.Parse(parts[6]);
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus, completed));
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}