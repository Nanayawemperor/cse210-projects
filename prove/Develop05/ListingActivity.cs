using System;
using System.IO.Pipes;
class ListingActivity : Activity
{
    private string[] _prompts = {
        "List the people you appreciate.",
        "List your personal strengths.",
        "List the people you helped this week."
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on positive things by making a list.")
    {

    }

    protected override void Run()
    {
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Length)]);
        ShowCountDown(3);

        int count = 0;
        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.Write("List item: ");
            Console.ReadLine();
            count++;
            elapsedTime += 5;
        }

        Console.WriteLine($"You listed {count} items.");
    }
}