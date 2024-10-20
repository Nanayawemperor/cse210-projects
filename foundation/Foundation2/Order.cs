using System;
class Order
{
    private List<Product> products = new List<Product>();
    private Customer _customer;
    private double _shippingCostUSA = 5.00;
    private double _shippingCostNotUSA = 35.00;

    public Order(Customer customer)
    {
        products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double TotalCost()
    {
        double total = 0;
        foreach (var product in products)
        {
            total +=product.GetTotalCost();
        }
        total += _customer.IsInUsa() ? _shippingCostUSA : _shippingCostNotUSA;
        return total;
    }

    public string GetPackingLabel()
    {
        var label = new System.Text.StringBuilder();
        label.AppendLine("Packing Label: ");
        foreach (var product in products)
        {
            label.AppendLine(product.ProductDetails());
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label: \n{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}