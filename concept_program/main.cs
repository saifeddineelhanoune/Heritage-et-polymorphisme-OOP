using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual void Introduce()
    {
        Console.WriteLine($"My name is {Name} and I'm {Age} years old.");
    }
}

public class Employee : Person
{
    public string JobTitle { get; set; }
    public decimal Salary { get; set; }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"I'm an employee with the job title {JobTitle} and a salary of {Salary}.");
    }
}

public class Student : Person
{
    public string School { get; set; }
    public List<string> Courses { get; set; }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"I'm a student at {School} and I'm taking the following courses:");
        foreach (string course in Courses)
        {
            Console.WriteLine(course);
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee()
        {
            Name = "John Doe",
            Age = 30,
            JobTitle = "Software Engineer",
            Salary = 5000
        };
        employee.Introduce();

        Console.WriteLine();

        Student student = new Student()
        {
            Name = "Jane Smith",
            Age = 20,
            School = "University of ABC",
            Courses = new List<string>() { "Math", "Science", "English" }
        };
        student.Introduce();
    }
}
