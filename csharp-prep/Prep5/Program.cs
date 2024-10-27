using System;

class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee hEmployee = new HourlyEmployee();
        hEmployee.SetName("Emmanuel");
        hEmployee.SetId("1010");
        hEmployee.SetAddress("Ghana");
        hEmployee.SetBirthday("May 10");
        hEmployee.SetPayRate(15);
        hEmployee.SetHoursWorked(40);

        SalaryEmployee sEmployee = new SalaryEmployee();
        sEmployee.SetName("Emperor");
        sEmployee.SetId("0101");
        sEmployee.SetAddress("Ghana");
        sEmployee.SetBirthday("July 10");
        sEmployee.SetSalary(60000);
        
        DisplayEmployeeInfo(hEmployee);
        DisplayEmployeeInfo(sEmployee);

        List<Employee> employees  = new List<Employee>();
        employees.Add(hEmployee);
        employees.Add(sEmployee);

        foreach (Employee emp in employees)
        {
            float pay = emp.GetPay();
        }


    }

    public static void DisplayEmployeeInfo(Employee employee)
    {
        float pay = employee.GetPay();
        Console.WriteLine($"{employee.GetName()} will be paid ${pay}");
    }
}