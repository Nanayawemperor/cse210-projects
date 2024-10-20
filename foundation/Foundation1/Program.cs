using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();


        Video video0 = new Video("Storm Over Paradise","Emmanuel",30);
        video0.AddComment(new Comment("Emmanuel","Thanks for the video!"));
        video0.AddComment(new Comment("Emma","Truly we are in the storm now"));
        video0.AddComment(new Comment("Emmanauella","Paradise here we come"));

        Video video1 = new Video("Birth of Christ","John",40);
        video1.AddComment(new Comment("Anita","Jesus in the manger"));
        video1.AddComment(new Comment("Ama","The video is very interesting"));
        video1.AddComment(new Comment("Ann","A clear storyline"));

        Video video2 = new Video("Death of Christ","Paul",50);
        video2.AddComment(new Comment("Michael","It is finished indeed"));
        video2.AddComment(new Comment("Michelle","Our plan of salvation is complete"));
        video2.AddComment(new Comment("Mark","Jesus is cruxified!"));

        Video video3 = new Video("The Coming King","Daniel",60);
        video3.AddComment(new Comment("Rocklyn","Jesus is our coming King"));
        video3.AddComment(new Comment("Rhoda","He will come in His glory"));
        video3.AddComment(new Comment("Reuben","We will ascend with Him"));

        videos.Add(video0);
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments: ");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._person}: {comment._text}");
                
            }
            Console.WriteLine(" ");
        }

    }
}