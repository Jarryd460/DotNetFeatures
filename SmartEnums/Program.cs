// See https://aka.ms/new-console-template for more information

using SmartEnums;

var free = Subscriptions.Free;
var freeToo = Subscriptions.Free;

Console.WriteLine(free == freeToo);

var freeFromName = Subscriptions.FromName("Free");
var freeFromValue = Subscriptions.FromValue(1);

Console.WriteLine(freeFromName == freeFromValue);

Console.WriteLine($"Discount was {Subscriptions.Vip.Discount}");