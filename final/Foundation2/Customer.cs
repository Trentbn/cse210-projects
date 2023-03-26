public class Customer
{
    private string _name;
    private Address _address;

    public Boolean UsaShipping()
    {
        Boolean usa  = _address.UsaShipping();
        if (usa == true)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return (_address.AddressString());
    }

    public Customer (string name, Address address)
    {
        _name = name;
        _address = address;
    }

}