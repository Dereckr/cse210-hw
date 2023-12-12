using System;
using System.Dynamic;

public class Customer
{
    private string _name="";

    public Address _address;


    public Customer(string name)
    {
        _name=name;
    }

    public bool IsUSA(){
        if (_address.IsUsa() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetLabel()
    {

        return $"{_name}\n{_address.GetAddress()}";
    }





    

}