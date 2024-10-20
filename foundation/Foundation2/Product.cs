using System;
class Product
{
    private string _productName;
    private int _productId;
    private int _price;
    private int _quantity;

    public Product()
    {
        _productName = "";
        _productId = 0;
        _price = 0;
        _quantity = 0;
    }

    public Product(string name, int productId, int price, int quantity )
    {
        _productName = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;

    }

    public int GetTotalCost()
    {
        return _price * _quantity;
    }

    public string ProductDetails()
    {
        return $"{_productName} (ID: {_productId} - Price: {_price}, Quantity: {_quantity})"  ;
    }
}