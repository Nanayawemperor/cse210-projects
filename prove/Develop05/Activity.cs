using System;

public abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name,string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}... \n{_description}");
        Console.WriteLine(" "); 
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready to begin...");
        ShowCountDown(3);

        Run();

        DisplayEndingMessage();
    }

    protected abstract void Run();

    private void DisplayEndingMessage()
    {
        Console.WriteLine("Well done");
        Console.WriteLine(" ");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowCountDown(3);
    }

    protected void ShowCountDown(int seconds)
    {
        for(int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    
}