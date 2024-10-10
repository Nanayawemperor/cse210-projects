using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Person myName = new Person();
        myName._familyName = "Emmanuel";
        myName._givenName = "Okyere";
        myName.ShowEasternName();
        myName.ShowWesternName();

        Blind kitchen = new Blind();
        kitchen._width = 60;
        kitchen._color = "white";
        kitchen._height = 48;
        Console.WriteLine(kitchen._color);
        Console.WriteLine($"Area of the kitchen is {kitchen.GetArea()}");
        
        Blind livingRoom = new Blind();
        livingRoom._height = 52;
        livingRoom._width = 72;
        livingRoom._color = "Blue";
        Console.WriteLine(livingRoom.GetArea());


    }
    
}

