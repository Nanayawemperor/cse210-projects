using System;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // No specific action for EternalGoal
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetDetailsString()
    {
        return $"{ShortName}: {Description} ({Points} points per event)";
    }

    public override string GetStringRepresentation()
    {
        return $"{ShortName},{Description},{Points}";
    }
}