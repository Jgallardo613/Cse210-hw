using System;
using System.Threading;

// Creative Feature Implemented: The program now tracks and displays how many times each activity was completed during the session.
public class Program
{
    public static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (choice == "4")
            {
                Activity.DisplayActivityLog();
                
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                Thread.Sleep(4000);
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to continue.");
                Console.ReadLine();
            }
        }
    }
}