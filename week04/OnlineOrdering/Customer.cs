public class Customer
{
    private string _name;
    private Address _address; // Address is a class defined elsewhere

    // Constructor to initialize customer details
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    
    // Getter for customer name
    public string GetName()
    {
        return _name;
    }

    // Getter for customer address
    public string GetAddress()
    {
        return _address.FullAddress();
    }

    // Method to get customer residence

    public bool IsUSAResidence()
    {
        string country = _address.GetCountry();
        return _address.IndicateLocation(country);

    }
        
      
}