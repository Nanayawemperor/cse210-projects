using System;

class Program
{
    static void Main(string[] args)
   {
        // Creating instances of each activity type
        Activity running = new Running("03 Nov 2022", 30, 4.8); // Distance in km
        Activity cycling = new Cycling("03 Nov 2022", 30, 20); // Speed in kph
        Activity swimming = new Swimming("03 Nov 2022", 30, 20); // Number of laps

        // Adding activities to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Displaying summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}