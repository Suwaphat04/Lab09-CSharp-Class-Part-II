﻿using System;

class Program
{
    static void Main()
    {
        Person.name = "___________________";
        System.Console.WriteLine(Person.GetName());
    }
}

static class Person
{
    public static string? name;

    public static string GetName()
    {
        return $"Hello from {name}";
    }
}

