using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string valueFromUser = Console.ReadLine();

        int percentage  = int.Parse(valueFromUser);

        string letter = "";
//If statements to determine the grade 
        if (percentage >=90)
        {
            letter = "A";
        }

        else if (percentage >=80)
        {
            letter = "B";
        }
        else if (percentage >=70)
        {
            letter = "C";
        }
        else if (percentage >=60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is : {letter}");
// if statement to determine if the user passed the course.
        if (percentage >=70)
        {
            Console.WriteLine("Well Done. Keep it up!!!");
        }
        else 
        {
            Console.WriteLine("Buckle up. More room for improvement.");
        }

    }
}