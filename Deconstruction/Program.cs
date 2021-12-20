// See https://aka.ms/new-console-template for more information
using System;

var jarryd = new Person
{
    FullName = "Jarryd Deane",
    DateOfBirth = new DateOnly(1992, 4, 29)
};

// Without class Deconstruct method
//var fullName = jarryd.FullName;
//var dateOfBirth = jarryd.DateOfBirth;

// With class Deconstruct method
//(var fullName, var dateOfBirth) = jarryd;

//Console.WriteLine($"The name is: {fullName}, born in {dateOfBirth:yyyyMMdd}");

// Discard values not wanted (dateOfBirth)
//(var fullName, var _) = jarryd;

//Console.WriteLine($"The name is: {fullName}");

// Deconstruct already exists on a number of classes in .NET, one being KeyValuePair<>
//Dictionary<string, int> dictionary = new Dictionary<string, int>()
//{
//    { "Jarryd Deane", 29 }
//};

//var (key, value) = dictionary.First();

//Console.WriteLine($"The name is: {key}, age: {value}");

// Some .NET classes do not have Deconstruct method but can be added using extension methods
//var dateOfBirth = new DateOnly(1992, 4, 29);

//var (year, month, day) = dateOfBirth;

//Tuples can also be Deconstructed
//var person = GetPersonDetails();
//var (name, age) = GetPersonDetails();

//Console.WriteLine($"The name is: {person.name}, age: {person.age}");
//Console.WriteLine($"The name is: {name}, age: {age}");

// Records have the Deconstruct method built in as well
var (title, isbn) = new Book("My Book", "1234567890");

Console.WriteLine($"My book's title is: {title}, ISBN: {isbn}");

(string name, int age) GetPersonDetails()
{
    return ("Jarryd Deane", 29);
}

public record Book(string Title, string ISBN);

public class Person
{
    public string FullName { get; init; } = default!;
    public DateOnly DateOfBirth { get; init; }

    // You can out any variables and does not have to match class properties
    public void Deconstruct(out string fullName, out DateOnly dateOfBirth)
    {
        fullName = FullName;
        dateOfBirth = DateOfBirth;
    }
}

public static class DeconstructionExtensions
{
    public static void Deconstruct(this DateOnly dateOnly, out int year, out int month, out int day)
    {
        year = dateOnly.Year;
        month = dateOnly.Month;
        day = dateOnly.Day;
    }
}
