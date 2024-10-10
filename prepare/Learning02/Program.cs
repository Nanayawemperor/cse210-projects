using System;

class Program
{
    static void Main(string[] args)
    {
       Resume myResume = new Resume();
       myResume._name = "Emmanuel Okyere";

       Job job1 = new Job();
       job1._companyName = "Microsoft";
       job1._jobTitle = "Industrial Engineer";
       job1._startYear = "2019";
       job1._endYear = "2022";


       Job job2 = new Job();
       job2._companyName = "Microsoft";
       job2._jobTitle = "Production Manager";
       job2._startYear = "2009";
       job2._endYear = "2024";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

       

    }
}