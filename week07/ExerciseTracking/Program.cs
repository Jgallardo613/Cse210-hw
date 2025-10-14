using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running runningActivity = new Running("03 Nov 2025", 30, 3.0);
        activities.Add(runningActivity);

        Cycling cyclingActivity = new Cycling("04 Nov 2025", 45, 15.0);
        activities.Add(cyclingActivity);

        Swimming swimmingActivity = new Swimming("05 Nov 2025", 60, 20);
        activities.Add(swimmingActivity);

        Console.WriteLine("--- Exercise Tracking Summary ---");
        Console.WriteLine();
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine(); 
        }

        Console.WriteLine("--- Report Complete ---");
    }
}