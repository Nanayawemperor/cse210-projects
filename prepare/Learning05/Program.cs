using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("+");

        Thread.Sleep(2000);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
    }
}
