using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a list to hold all the Video objects.
        // This is a central place to store and manage all the videos.
        List<Video> videos = new List<Video>();

        // Step 2: Create each video and add its comments.
        // I made sure to include 3-4 videos, each with multiple comments
        // as the assignment required.

        // Video 1: C# Programming Basics
        Video video1 = new Video("C# Basics: Variables", "Programming Guru", 650);
        video1.AddComment("Alice", "Great tutorial, very clear!");
        video1.AddComment("Bob", "I learned so much, thank you!");
        video1.AddComment("Charlie", "Can you do a video on classes next?");
        videos.Add(video1); // Add the complete video object to the list.

        // Video 2: OOP Principles
        Video video2 = new Video("OOP Principles", "Code Master", 900);
        video2.AddComment("David", "This video was so helpful for my class.");
        video2.AddComment("Emily", "The abstraction part was a little confusing.");
        video2.AddComment("Frank", "Thanks for the clear examples!");
        videos.Add(video2);

        // Video 3: Introduction to Git
        Video video3 = new Video("Introduction to Git", "DevOps Daily", 400);
        video3.AddComment("Grace", "Perfect for a beginner like me.");
        video3.AddComment("Heidi", "The diagrams were super helpful.");
        video3.AddComment("Ivan", "What about pull requests?");
        videos.Add(video3);

        // Step 3: Loop through the list and display the information for each video.
        // This keeps the display logic separate from the creation logic.
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}