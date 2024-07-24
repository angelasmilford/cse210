using System;

public class Address
{
    private string _streetAddress {get; set; }
    private string _city {get; set; }
    private string _stateOrProvince {get; set; }
    private string _country {get; set;}

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public override string ToString()
    {
        return $"{_streetAddress}, {_city}, {_stateOrProvince} {_country}";
    }
}