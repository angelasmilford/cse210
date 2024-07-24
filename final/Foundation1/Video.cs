using System;
using System.Security.Principal;

public class Video
{
    public string _title;
    public string _name;
    public int _length;
    public List<Comment> _comments;

    public Video(string title, string name, int length)
    {
        _title = title;
        _name = name;
        _length = length;
        _comments = new List<Comment>();
    }

    public string GetTitle()
    {
        return _title;
    }   

    public string GetName()
    {
        return _name;
    }

    public int GetLength()
    {
        return _length;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public int GetCommentCount()
    {
        int commentCount = _comments.Count;
        return commentCount;
        //return $"Number of comments: {commentCount}"
    }

    public void AddComment(string author, string text)
    {
        _comments.Add(new Comment(author, text));
    }

}