using System.Collections.Generic; // Needed for List<Job>

public class Resume
{
    // This will hold the person's name.
    public string _name = "";

    // This will hold a list of Job objects.
    // We initialize it as an empty list immediately.
    public List<Job> _jobs = new List<Job>();

    // This method will display the person's name and then all their jobs.
    public void Display()
    {
        // Print the name
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:"); // Heading for the job list

        // Loop through each Job object in the _jobs list
        foreach (Job job in _jobs)
        {
            // Call the Display method of each Job object
            job.Display();
        }
    }
}