using System;
using System.Collections.Generic; // Make sure this is here!

public class Program
{
    public static void Main(string[] args)
    {
        // --- This is the part you'll add/modify in Program.cs ---

        // Create the first job object
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Create the second job object
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Create the resume object
        Resume myResume = new Resume();
        myResume._name = "Jeffrey Gallardo";

        // Add the job objects to the resume's list of jobs
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Call the Display method on the resume to show everything
        myResume.Display();

        // --- End of the part you'll add/modify ---
    }
}