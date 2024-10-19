using System;
using System.ComponentModel.DataAnnotations;
public class Video
{
    public string _title;
    public string _author;
    public int _lenghtOfVideo;
    public List<Comment> comments = new List<Comment>();

    public Video()
    {
        _title = "";
        _author = "";
        _lenghtOfVideo = 0;

    }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lenghtOfVideo = length;
    }


    public void GetNumberOfComments()
    {
        for (int i = 0; i < comments.Count;i++)
        {
            Console.WriteLine(comments[i]);
        }
        
    }
}