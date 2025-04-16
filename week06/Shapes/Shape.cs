public class Shape
{
    private string _color;

    // Getter  for Color property
    public string GetColor()
    {
        return _color;
    }

    // Setter for Color property
    public void SetColor(string color)
    {
        _color = color;
    }

    // Constructor to initialize the color
    public Shape(string color)
    {
        _color = color;
    }

    // Method to calculate area (to be overridden in derived classes)
    public virtual double CalculateArea()
    {
        return 0.0; // Default implementation (can be overridden)
    }
}