public class Product
{
    private string _productName;
    private string _productId;
    private float _productPrice;
    private int _quantity;

// Create constructor for Product class
    // Constructor to initialize product details
    public Product(string productName, string productId, float productPrice, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _quantity = quantity;
    }

    // Getter for product name
    public string GetProductName()
    {
        return _productName;
    }

    // Getter for product ID
    public string GetProductId()
    {
        return _productId;
    }

    // Method to get product total price
    public float ProductTotalPrice()
    {
        return _productPrice * _quantity;
    }
}