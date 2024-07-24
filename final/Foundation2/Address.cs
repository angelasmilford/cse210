using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    public bool IsInUSA()
    {
        if( _country.ToUpper().Equals("USA"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetAddress()
    {
        string formattedAddress = $"   {_streetAddress}\n   {_city}\n   {_stateOrProvince}\n   {_country}";
        return formattedAddress;
    }
}