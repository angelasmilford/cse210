public class Customer
{
    private string _name;
    private Address _addres;

    public Customer(string name, Address address)
    {
        _name = name;
        _addres = address;

    }
    public string GetName()
    {
        return _name;
    }
    public bool IsInUSA()
    {
        return _addres.IsInUSA();
    }
    public Address GetAddress()
    {
        return _addres;
    }

}