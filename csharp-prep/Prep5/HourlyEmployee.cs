using System;
public class HourlyEmployee : Employee
{
    private float _hourlyPayRate = 9f;
    private float _hoursWorked = 100f;

    public float GetPayRate()
    {
        return _hourlyPayRate;
    }
    public float GetHoursWorked()
    {
        return _hoursWorked;
    }
    public void SetPayRate(float payrate)
    {
        _hourlyPayRate = payrate;
    }
    public void SetHoursWorked(float hoursworked)
    {
        _hoursWorked = hoursworked;
    }

    public override float GetPay()
    {
        return _hourlyPayRate * _hoursWorked;
    }
}