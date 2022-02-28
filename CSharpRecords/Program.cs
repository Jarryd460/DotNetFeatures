// See https://aka.ms/new-console-template for more information

using CSharpRecords;

// Constructor taking 2 arguments is automatically generated
var jarrydAsRecord = new PersonAsRecord("Jarryd Deane", new DateOnly(1992, 4, 29));

Console.WriteLine(jarrydAsRecord);

var jarrydAsClass = new PersonAsClass()
{
    Fullname = "Jarryd Deane",
    DateOfBirth = new DateOnly(1992, 4, 29)
};

Console.WriteLine();
Console.WriteLine(jarrydAsClass);

var jarrydAsClass2 = new PersonAsClass()
{
    Fullname = "Jarryd Deane",
    DateOfBirth = new DateOnly(1992, 4, 29)
};

Console.WriteLine();
Console.WriteLine($"jarrydAsClass == jarrydAsClass2: {jarrydAsClass == jarrydAsClass2}");
Console.WriteLine($"jarrydAsClass.Equals(jarrydAsClass2): {jarrydAsClass.Equals(jarrydAsClass2)}");

var jarrydAsRecord2 = new PersonAsRecord("Jarryd Deane", new DateOnly(1992, 4, 29));

Console.WriteLine();
// Equality check is overridden. To check for reference equality ReferenceEquals must be used
Console.WriteLine($"jarrydAsRecord == jarrydAsRecord2: {jarrydAsRecord == jarrydAsRecord2}");
Console.WriteLine($"jarrydAsRecord.Equals(jarrydAsRecord2): {jarrydAsRecord.Equals(jarrydAsRecord2)}");
Console.WriteLine($"ReferenceEquals(jarrydAsRecord, jarrydAsRecord2): {ReferenceEquals(jarrydAsRecord, jarrydAsRecord2)}");

// Clone method is automatically generated
var olderJarryd = jarrydAsRecord with
{
    DateOfBirth = new DateOnly(1991, 4, 29)
};

Console.WriteLine();
Console.WriteLine(olderJarryd);

// Deconstruct method is automatically generated
var(fullname, dateOfBirth) = olderJarryd;

Console.WriteLine($"Fullname: {fullname}, dateOfBirth: {dateOfBirth}");