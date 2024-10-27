using System;
public abstract class Employee
{
    protected string _name;
    protected string _id;
    private string _address;
    private string _birthday;

    public Employee()
    {
    }

    public string GetName()
    {
        return _name;
    }
    public string GetId()
    {
        return _id;
    }
    public string GetAddress()
    {
        return _address;
    }
    public string GetBirthday()
    {
        return _birthday;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetId(string id)
    {
        _id = id;
    }
    public void SetAddress(string address)
    {
        _address = address;
    }
    public void SetBirthday(string birthday)
    {
        _birthday = birthday;
    }

    public abstract float GetPay();

}