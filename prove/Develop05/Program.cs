using System;
public class Program
{
    public static void Main(string[]args)
    {
        while(true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Breathing Activity");
            Console.WriteLine("  2. Reflection Activity");
            Console.WriteLine("  3. Listing Activity");
            Console.WriteLine("  4. Exit");
            Console.Write("Select a choice from the menu: ");

            int choice = int.Parse(Console.ReadLine());
            Activity activity = null;
            switch(choice)
            {
                  case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectingActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 4:
                    return; 
            }

            if (activity != null)
            {
                activity.DisplayStartingMessage();
            }
        }
    }
}