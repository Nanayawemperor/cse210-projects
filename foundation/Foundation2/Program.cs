using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        
        var address = new Address("Laloi Ave","Accra","GreaterAccra","Ghana");
        var address1 = new Address("Kotopon Lane","Accra","GreaterAccra","Ghana");

        Customer customer = new Customer("Emmanuel Okyere",address);
        Customer customer1 = new Customer("John DTF",address1);

        var product = new Product("Calculator",1001,100,10);
        var product1 = new Product("Vaseline", 20, 35,1);
        var product2 = new Product("Perfum", 201, 55,4);
        var product3 = new Product("Napkin", 2, 5,2);

        var order1 = new Order(customer);
        order1.AddProduct(product);
        order1.AddProduct(product1);

        var order2 = new Order(customer1);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.TotalCost()}");

        Console.WriteLine(" ");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${ order2.TotalCost()}");

    }
}