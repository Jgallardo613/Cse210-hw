using System;
using System.Collections.Generic;

public class Video
{
    // These are the private member variables to hold the video's information.
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public List<Comment> _comments;

    // The constructor is called when a new Video object is created.
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        // It's important to initialize the list of comments here!
        _comments = new List<Comment>();
    }

    // This method adds a new comment to the video's list.
    public void AddComment(string commenterName, string commentText)
    {
        Comment newComment = new Comment(commenterName, commentText);
        _comments.Add(newComment);
    }

    // This method returns the total number of comments,
    // which is a key requirement of the assignment.
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // This method handles all the display logic for a single video.
    // I put this here to keep the Program.cs file clean.
    public void DisplayInfo()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        // I used a foreach loop to go through each comment in the list
        // and display it in a clear, organized way.
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment._commenterName}: {comment._commentText}");
        }
    }
}