using System;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        Person p2 = new Person("Emmanuel","Okyere");
        Person p3 = new Person("Mr.","Emmanuel","Okyere");

        Console.WriteLine(p3.GetFullName());
    }
}