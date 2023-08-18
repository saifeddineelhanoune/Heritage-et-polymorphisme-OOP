// Base class
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

// Derived classes inheriting from Shape
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}

// Usage
Shape shape1 = new Circle();
shape1.Draw();  // Output: "Drawing a circle."

Shape shape2 = new Rectangle();
shape2.Draw();  // Output: "Drawing a rectangle."
