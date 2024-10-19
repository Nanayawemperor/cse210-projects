using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video = new Video("Storm Over Paradise","Emmanuel",30);
        List<Comment> comments = new List<Comment>();
        Comment comment1 = new Comment("Emmanuel","Thanks for the video!");
        Comment comment2 = new Comment("Emma","Truly we are in the storm now");
        Comment comment3 = new Comment("Manuel","Paradise here we come");

        Video video1 = new Video("Birth of Christ","John",40);
        Comment comment4 = new Comment("Emmanuel","Jesus in the manger");
        Comment comment5 = new Comment("Emma","The video is very interesting");
        Comment comment6 = new Comment("Manuel","A clear storyline");

        Video video2 = new Video("Death of Christ","Paul",50);
        Comment comment7 = new Comment("Emmanuel","It is finished indeed");
        Comment comment8 = new Comment("Emma","Our plan of salvation is complete");
        Comment comment9 = new Comment("Manuel","Jesus is cruxified!");

        Video video3 = new Video("The Coming King","Daniel",60);
        Comment comment10 = new Comment("Emmanuel","Jesus is our coming King");
        Comment comment11 = new Comment("Emma","He will come in His glory");
        Comment comment12 = new Comment("Manuel","We will ascend with Him");



        comments.Add(comment1);
        comments.Add(comment2);
        comments.Add(comment3);
        comments.Add(comment4);
        comments.Add(comment5);
        comments.Add(comment6);
        comments.Add(comment7);
        comments.Add(comment8);
        comments.Add(comment9);
        comments.Add(comment10);
        comments.Add(comment11);
        comments.Add(comment12);
        foreach (Comment comment in comments)
        {
            Console.WriteLine($"{comment._person} : {comment._text}");
        }

        videos.Add(video);
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {video1._title} Author: {video1._author} Length: {video1._lenghtOfVideo} ");
            
        }


        




    }
}