using System;

public class Address
{
    private string _street="";
    private string _stateProvince="";
    private string _city="";
    private string _country="";

    public Address(string street, string stateProvince, string city, string country)
    {
        _street=street;
        _stateProvince=stateProvince;
        _city=city;
        _country=country;
    }

    public string GetAddress(){

        return $"{_street}\n{_stateProvince}\n{_city}\n{_country}";
    }

    public bool IsUsa()
    {
        if (_country=="USA")
        {
        
            return true;
        }
        else
        {
            return false;
        }

    }





    

}