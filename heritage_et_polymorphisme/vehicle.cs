// Base class
public class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public virtual void StartEngine()
    {
        Console.WriteLine("Starting the engine of the vehicle.");
    }
}

// Derived classes inheriting from Vehicle
public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Starting the engine of the car.");
    }
}

public class Motorcycle : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Starting the engine of the motorcycle.");
    }
}

// Usage
Vehicle vehicle = new Vehicle();
vehicle.StartEngine();  // Output: "Starting the engine of the vehicle."

Car car = new Car();
car.StartEngine();  // Output: "Starting the engine of the car."

Motorcycle motorcycle = new Motorcycle();
motorcycle.StartEngine();  // Output: "Starting the engine of the motorcycle."
