﻿namespace Packt.Shared;

public class Person : object
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }
}
