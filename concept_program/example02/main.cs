using System;
/* example of C# programming with Multiple Level Inheritance (MLS) using the concept of multi-level inheritance: */
public class Animal
{
    public void Eat()
	{
        Console.WriteLine("Animal is eating.");
	}
}

public class Mammal : Animal
{
    public void Sleep()
    {
        Console.WriteLine("Mammal is sleeping.");
    }
}

public class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Eat();   // Inherited from Animal class
        dog.Sleep(); // Inherited from Mammal class
        dog.Bark();  // Defined in Dog class
    }
}

/*In this example:

The Animal class is the base class that has a method Eat().
The Mammal class is derived from the Animal class and adds a method Sleep().
The Dog class is derived from the Mammal class and adds a method Bark().
In the Main method, we create an instance of the Dog class and call the inherited methods Eat() and Sleep(), as well as the method Bark() defined in the Dog class.
When you run this code, the output will be:

Animal is eating.
Mammal is sleeping.
Dog is barking.
*/
