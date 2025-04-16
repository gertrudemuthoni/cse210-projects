public class Square : Shape
{
    private double _side;

    // Constructor to initialize the side length and color
    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    // Method to calculate the area of the square
    public override double CalculateArea()
    {
        return _side * _side;
    }
}