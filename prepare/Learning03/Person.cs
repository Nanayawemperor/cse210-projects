using System;
public class Person
{
    private string _firstName;
    private string _title;
    private string _lastName;

    public Person()
    {
        _title = "";
        _firstName = "Emmanuel";
        _lastName = "Okyere";
    }

    public Person(string first, string last)
    {
        _firstName = first;
        _lastName = last;
    }
    public Person(string title, string first, string last)
    {
        _title = title;
        _firstName = first;
        _lastName = last;
    }

    public string GetFullName()
    {
        return _title + " " +_lastName +" "+ _firstName;
    }
   
    
}