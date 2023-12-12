using System;
using System.ComponentModel;

public class Order
{
    private double _sum; 
    public Customer _customer;
    
    public List<Product> _products = new List<Product>();
    

    public void calculateTotal()
    {   
        
        foreach(Product product in _products )
        {
            _sum+=product.GetProductPrice();
        }

        if(_customer.IsUSA()==true)
        {
            Console.WriteLine("Shipping cost is 5");
            _sum=_sum+5;
        }
        else
        {
            Console.WriteLine("Shipping cost is 35");
            _sum=_sum+35;
        }

        Console.WriteLine($"The total price of the order plus shipping is: {_sum}");
        Console.WriteLine();
    
    }

    public void packingLabel()
    {
        foreach (Product product in _products)
        {
            product.GetPackingLabel();
        }
        Console.WriteLine();
    }

     public void GetShippingLabel()
    {
        Console.WriteLine(_customer.GetLabel());
        Console.WriteLine();
    }

}