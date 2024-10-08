using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<string>words = new List<string>();

        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
        Console.WriteLine(words.Count);


        List<int>numbers = new List<int>();

        int userNumber = -1;

        

        

        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");

            string valueFromUser = Console.ReadLine();
            userNumber = int.Parse(valueFromUser);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        //Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Compute the average 
        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Find the max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

        //Find min
        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number<min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The smallest number is: {min}");
    }
}