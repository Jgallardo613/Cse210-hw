using System;

public class Comment
{
    // These are the member variables to hold the comment's information.
    public string _commenterName;
    public string _commentText;

    // This constructor makes sure that when a new Comment object is created,
    // it always has a name and text associated with it.
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }
}