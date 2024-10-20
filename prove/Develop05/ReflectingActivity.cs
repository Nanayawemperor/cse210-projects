using System;
class ReflectingActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };
    private string [] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times when you have shown strength.")
    {

    }

    protected override void Run()
    {
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Length)]);
        ShowCountDown(3);

        int elapsedTime = 0;
        while (elapsedTime< _duration)
        {
            Console.WriteLine(_questions[random.Next(_questions.Length)]);
            ShowCountDown(5);
            elapsedTime += 5;
        }
    }
}