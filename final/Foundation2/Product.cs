using System;

public class Product
{
    private string _productName="";
    private string _productId="";
    private double _price;
    private int _quantity;

    public Product(string productName, string productID, double price, int quantity)
    {
        _productName=productName;
        _productId = productID;
        _price=price;
        _quantity=quantity;
    }

    public double GetProductPrice()
    {
        return _price*_quantity;
    }

    public void GetPackingLabel()
    {
        Console.WriteLine($"Product Name: {_productName}\nProduct id:{_productId}");
    }

   





    

}