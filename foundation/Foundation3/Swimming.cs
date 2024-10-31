using System;
using System.Diagnostics;
class Swimming : Activity
{
    private int laps;
    private const double LapLengthMeters = 50; 

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance() => (laps * LapLengthMeters) / 1000;

    public override double GetSpeed() => (GetDistance() / Minutes) * 60;

    public override double GetPace() => Minutes / GetDistance();
}