using System;

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.name = "____Person name _____";
        System.Console.WriteLine(person.GetName());
        
        Student student = new Student();
        student.name = "_______student name_______";
        System.Console.WriteLine(student.GetName());
    }
}

class Person
{
    public string? name;

    public virtual string GetName()
    {
        return $"Hello from {name}";
    }
}

class Student : Person
{
    public override string GetName()
    {
        return $"Hello from Student: {name}";
    }
}
