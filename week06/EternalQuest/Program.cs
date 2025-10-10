using System;

/*
 * EXCEEDED REQUIREMENTS: 
 * Implemented a Title System that assigns the user a rank (Novice, Apprentice, Master)
 * based on their current point total. This adds a gamification element to the program.
*/
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        bool running = true;
        while (running)
        {
            manager.DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Record Event");
            Console.WriteLine("  4. Save Goals");
            Console.WriteLine("  5. Load Goals");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                manager.CreateGoal();
            }
            else if (choice == "2")
            {
                manager.ListGoalDetails();
            }
            else if (choice == "3")
            {
                manager.RecordEvent();
            }
            else if (choice == "4")
            {
                manager.SaveGoals();
            }
            else if (choice == "5")
            {
                manager.LoadGoals();
            }
            else if (choice == "6")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}