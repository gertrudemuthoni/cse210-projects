public class Address
{
    private string _stringAddress;
    private string _city;
    private string _state;
    private string _country;



    // Constructor to initialize the address
    public Address(string stringAddress, string city, string state, string country)
    {
        _stringAddress = stringAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // Getter for country
    public string GetCountry()
    {
         return _country; 
    }

    // Method to get the address
    public string FullAddress()
    {
        return $"Address: {_stringAddress},  {_city}, {_state}, {_country}";
    }


    // Method to check location (USA or not)
    public bool IndicateLocation(string country)
    {
        if (country.ToUpper() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}