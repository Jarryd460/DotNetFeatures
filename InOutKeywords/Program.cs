// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using InOutKeywords;

//int value = 5;
//OutExample.ExampleOut(out value);
//Console.WriteLine(value);

//(var success, value) = OutExample.TryParse("sdfa");

//Console.WriteLine($"Success: {success}, Value: {value}");

//var difference = InExample.CalculateDistance(new Point(2, 4, 6), new Point(8, 2, 1));

//Console.WriteLine($"Difference: {difference}");

BenchmarkRunner.Run<BenchMark>();