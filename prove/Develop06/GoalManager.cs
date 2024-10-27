public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        // Implement game logic here, including displaying player info, listing goals, etc.
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.Write("Which type of goal would you like t o create? ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CreateSimpleGoal();
                break;
            case 2:
                CreateEternalGoal();
                break;
            case 3:
                CreateChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    private void CreateSimpleGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        _goals.Add(new SimpleGoal(name, description, points));
    }

    private void CreateEternalGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        _goals.Add(new EternalGoal(name, description, points));
    }

    private void CreateChecklistGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());

        _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
    }

    public void RecordEvent(int index)
    {
        if (index >= 1 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += _goals[index].Points;
            Console.WriteLine($"Congratulations! You have earned {_score} points");
        }
    }

    public void SaveGoals(string filePath)
    {
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
        }
        
    }

    public void LoadGoals(string filePath)
    {
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Parse the line and create a new Goal object
                    // You'll need to implement the parsing logic based on your goal format
                    // For example, you might split the line by commas and create a goal object
                    // based on the parsed values.

                    Goal goal = ParseGoal(line);
                    _goals.Add(goal);
                }
            }
        }
    }

    private Goal ParseGoal(string line)
{
    {
        string[] parts = line.Split(',');

        if (parts.Length < 3)
        {
            Console.WriteLine("Invalid goal format: Missing required fields.");
            return null;
        }

        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);

        if (parts.Length == 3)
        {
            return new SimpleGoal(name, description, points);
        }
        else if (parts.Length == 5)
        {
            int target = int.Parse(parts[3]);
            int bonus = int.Parse(parts[4]);
            return new ChecklistGoal(name, description, points, target, bonus);
        }
        else
        {
            Console.WriteLine("Invalid goal format: Unexpected number of fields.");
            return null;
        }
    }
}

    public List<Goal> Goals { get { return _goals; } }
    public int Score { get { return _score; } }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
        }
        else
        {
            Console.WriteLine("List of Goals:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. { _goals[i].GetDetailsString()}");
            }
        }
    }
    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
        }
        else
        {
            Console.WriteLine("Your Goals:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. { _goals[i].GetDetailsString()}");
            }
        }
    }
    public int GetTotalScore()
    {
        return _score;
    }
}