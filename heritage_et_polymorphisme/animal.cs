// Base class
public class Animal
{
    public string Name { get; set; }

    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

// Derived class inheriting from Animal
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

// Usage
Animal animal = new Animal();
animal.MakeSound();  // Output: "The animal makes a sound."

Dog dog = new Dog();
dog.MakeSound();  // Output: "The dog barks."
