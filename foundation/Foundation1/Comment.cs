using System;
public class Comment
{
    //fields
    public string _person;
    public string _text;

    //constructors
    public Comment()
    {
        _person = "";
        _text = "";
    }

    public Comment(string person, string comments)
    {
        _person = person;
        _text = comments;
    } 
}