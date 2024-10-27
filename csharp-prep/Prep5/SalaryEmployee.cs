using System;
public class SalaryEmployee : Employee
{
    private float _annualSalary = 0;

    public float GetSalary()
    {
        return _annualSalary;
    }
    public void SetSalary(float salary)
    {
        _annualSalary = salary;
    }

    public override float GetPay()
    {
        return _annualSalary/12;
    }
}