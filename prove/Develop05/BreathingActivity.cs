using System;
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding your breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    protected override void Run()
    {
        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.WriteLine("Breate in...");
            ShowCountDown(3);

            Console.WriteLine("Now breathe out...");
            ShowCountDown(3);

            elapsedTime += 6;
        }
    }

}