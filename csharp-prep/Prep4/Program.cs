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

        Console.Write("Enter a list of numbers, type 0 when finished.");
        string valueFromUser = Console.ReadLine();

        int number = int.Parse(valueFromUser);
         List<int>numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter Number: ");
            string newNumber = Console.ReadLine();
            int nmber = int.Parse(newNumber);
            numbers.Add(nmber);
        }
        
    }
}