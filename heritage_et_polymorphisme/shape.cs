// Base class
public abstract class Shape
{
    public abstract double CalculateArea();
}

// Derived classes inheriting from Shape
public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

// Usage
Shape shape1 = new Circle() { Radius = 5 };
double area1 = shape1.CalculateArea();  // Output: 78.53981633974483

Shape shape2 = new Rectangle() { Width = 4, Height = 6 };
double area2 = shape2.CalculateArea();  // Output: 24
