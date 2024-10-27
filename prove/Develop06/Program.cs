using System.IO;

using System;

public class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

         while (true)
        {
            Console.WriteLine($"You have {manager.Score} points.");
            Console.WriteLine(" ");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Record Event");
            Console.WriteLine("   4. Save Goals");
            Console.WriteLine("   5. Load Goals");
            Console.WriteLine("   6. Quit");

            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.CreateGoal();
                    break;
                case 2:
                    manager.ListGoals();
                    break;
                case 3:
                    Console.WriteLine("The goals are: ");
                    Console.WriteLine($"{manager.ListGoals}");
                    Console.Write("Which goal did you accomplish? ");
                    int index = int.Parse(Console.ReadLine());
                    manager.RecordEvent(index);
                    break;
                case 4:
                    Console.Write("Enter file path to save goals: ");
                    string savePath = Console.ReadLine();
                    manager.SaveGoals(savePath);
                    break;
                case 5:
                    Console.Write("Enter file path to load goals: ");
                    string loadPath = Console.ReadLine();
                    manager.LoadGoals(loadPath);
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}