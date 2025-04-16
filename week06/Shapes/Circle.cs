public class Circle : Shape
{
    private double _radius;

    // Constructor to initialize the radius and color
    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    // Method to calculate the area of the circle
    public override double CalculateArea()
    {
        return Math.PI * _radius * _radius; // Area = π * r^2
    }
}
