using System;
class Customer
{
    private string _name;
    private Address CustomerAddress{get; set;}

    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return CustomerAddress;
    }

    public Customer(string name, Address address)
    {
        _name = name;
        CustomerAddress = address;
    }

    public bool IsInUsa()
    {
        return CustomerAddress.IsCountryUSA();
    }

    public string GetCustomerDetails()
    {
        return $"{_name} - Address: {CustomerAddress.DisplayAddress()}";
    }

}