using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public List<Comment> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comment newComment = new Comment(commenterName, commentText);
        _comments.Add(newComment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment._commenterName}: {comment._commentText}");
        }
    }
}