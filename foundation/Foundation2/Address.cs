using System;
using System.Diagnostics.Contracts;

class Address
{
    private string _streetAdress;
    private string _theCity;
    private string _state;
    private string _country;


    public Address (string street, string city, string state, string country)
    {
        _streetAdress = street;
        _theCity = city;
        _state = state;
        _country = country;
    }

    public bool IsInUsa()
    {
        return _country.ToLower() == "usa";
    }


    public string GetFullAddres()
    {
        string fullAddress = $"{_streetAdress}, {_theCity}, {_state}, {_country}";
        return fullAddress;
    }


}