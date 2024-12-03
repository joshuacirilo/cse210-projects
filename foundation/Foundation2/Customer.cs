using System;
using System.Runtime.Serialization;
class Customer
{

    private string _name; 
    private Address addresso;

    public Customer(string name, Address address)
    {
            addresso = address;
            _name = name; 
    }

    public bool LivesInUsa()
    {

        return addresso.IsInUsa();
    }

    public string GetName()
    {
        return _name;
    }



    public string GetCustomerInformation()
    {
        
        string customerInformation = $"{_name}, {addresso.GetFullAddres()}";
        return customerInformation;
    } 

}