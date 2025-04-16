public class Rectangle : Shape{
    private double _length;
    private double _width;

    // Constructor to initialize the length, width, and color
    public Rectangle(double length, double width, string color) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Method to calculate the area of the rectangle
    public override double CalculateArea()
    {
        return _length * _width;
    }
}