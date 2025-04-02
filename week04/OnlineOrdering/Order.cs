public class Order
{
    public List<Product> _products = new List<Product>();
    
    public Customer _customer;

    // Constructor of the order
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;// List of products 
    }

    //Method to get shipping cost
    public int GetShippingCost()
    {
        int shippingCost ;
        if (_customer.IsUSAResidence())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return shippingCost;
    }

    //Method to gettotal price for each product
    public float GetTotalPrice()
    {
        float totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.ProductTotalPrice();
        }
        return totalPrice + GetShippingCost();
    }

    //Method to get packing label
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label: \n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductName()} - {product.GetProductId()} \n";
        }
        return packingLabel;
    }

    //Method to get shipping label
    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label: \n";
        shippingLabel += $"{_customer.GetName()} \n";
        shippingLabel += $"{_customer.GetAddress()} \n";
        return shippingLabel;
    }

}