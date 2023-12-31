﻿using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using Packt.Shared;

Thread.CurrentThread.CurrentCulture =
System.Globalization.CultureInfo.GetCultureInfo("en-GB");

Person max = new();
max.Name = "Max Burrows";
max.DateOfBirth = new DateTime(1997, 11, 5);
max.FavouriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
max.BucketList = 
    WondersOfTheAncientWorld.HangingGardensOfBabylon
    | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
max.Children.Add(new() {Name="Zoe"});
max.Children.Add(new() {Name="Alfred"});
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: max.Name,
    arg1: max.DateOfBirth);
WriteLine(format: "{0}'s favourite wonder is {1}. Its integer is {2}.",
    arg0: max.Name,
    arg1: max.FavouriteAncientWonder,
    arg2: (int) max.FavouriteAncientWonder);
WriteLine($"{max.Name}'s bucket list is {max.BucketList}");
WriteLine($"{max.Name} has {max.Children.Count} children:");
foreach(Person child in max.Children)
{
    WriteLine($"> {child.Name}");
}
WriteLine($"{max.Name} is a {Person.Species}");
WriteLine($"{max.Name} was born on {max.HomePlanet}");


Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7)
};
WriteLine(format: "{0} was born on {1:dd MMM yy}",
    arg0: alice.Name,
    arg1: alice.DateOfBirth);

BankAccount.InterestRate = 0.012M;
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine(format: "{0} earned {1:C} interest.",
arg0: jonesAccount.AccountName,
arg1: jonesAccount.Balance * BankAccount.InterestRate);
BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
arg0: gerrierAccount.AccountName,
arg1: gerrierAccount.Balance * BankAccount.InterestRate);

Person blankPerson = new();
WriteLine(format:
    "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated);

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: gunny.Name,
    arg1: gunny.HomePlanet,
    arg2: gunny.Instantiated);

max.WriteToConsole();
WriteLine(max.GetOrigin());

(string, int) fruit = max.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

var fruitNamed = max.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
var thing2 = (max.Name, max.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");

(string fruitName, int fruitNumber) = max.GetFruit();
WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

var (name1, dob1) = max;
WriteLine($"Deconstructed: {name1}, {dob1}");
var (name2, dob2, fav2) = max;
WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

WriteLine(max.SayHello());
WriteLine(max.SayHello("Emily"));

int a = 10;
int b = 20;
int c = 30;
WriteLine($"Before: a = {a}, b = {b}, c = {c}");
max.PassingParameters(a, ref b, out c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");

int d = 10;
int e = 20; 
WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");
max.PassingParameters(d, ref e, out int f);
WriteLine($"After: d = {d}, e = {e}, f = {f}");

Person sam = new()
{
    Name = "Sam",
    DateOfBirth = new(1969, 6, 25)
};
WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavouriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavouriteIceCream}.");
sam.FavoritePrimaryColor = "Red";
WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");

// Book book = new();
// book.Title = "C# 11 and .NET 7 - Modern Cross-Platform Development";

sam.Children.Add(new() { Name = "Charlie", DateOfBirth = new(2010, 3, 18)});
sam.Children.Add(new() { Name = "Ella", DateOfBirth = new(2020, 12, 24)} );
WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");
WriteLine($"Sam's first child is {sam[0].Name}.");
WriteLine($"Sam's second child is {sam[1].Name}.");
WriteLine($"Sam's child named Ella is {sam["Ella"].Age} years old.");

Person lamech = new() { Name = "Lamech" };
Person adah = new() { Name = "Adah" };
Person zillah = new() { Name = "Zillah" };
lamech.Marry(adah);
// Person.Marry(zillah, lamech);
if (zillah + lamech)
{
    WriteLine($"{zillah.Name} and {lamech.Name} successfully got married.");
}
WriteLine($"{lamech.Name} is married to {lamech.Spouse?.Name ?? "nobody"}");
WriteLine($"{adah.Name} is married to {adah.Spouse?.Name ?? "nobody"}");
WriteLine($"{zillah.Name} is married to {zillah.Spouse?.Name ?? "nobody"}");
Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.DateOfBirth}");
Person baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tubalcain";
Person baby3 = lamech * adah;
baby3.Name = "Jubal";
Person baby4 = zillah * lamech;
baby4.Name = "Naamah";
WriteLine($"{lamech.Name} has {lamech.Children.Count} children.");
WriteLine($"{adah.Name} has {adah.Children.Count} children.");
WriteLine($"{zillah.Name} has {zillah.Children.Count} children.");
for (int i = 0; i < lamech.Children.Count; i++)
{
    WriteLine(format: "{0}'s child #{1} is named \"{2}\".",
        arg0: lamech.Name, arg1: i, arg2: lamech[i].Name);
}

WriteLine($"5! is {Person.Factorial(5)}");

Passenger[] passengers = {
    new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
    new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy" },
    new BusinessClassPassenger { Name = "Janice" },
    new CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave" },
    new CoachClassPassenger { CarryOnKG = 0, Name = "Amit" }
};
// foreach (Passenger passenger in passengers)
// {
//     decimal flightCost = passenger switch
//     {
//         FirstClassPassenger p when p.AirMiles > 3500 => 1500M,
//         FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
//         FirstClassPassenger _ => 2000M,
//         BusinessClassPassenger _ => 1000M,
//         CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
//         CoachClassPassenger _ => 650M,
//         _ => 800M
//     };
//     WriteLine($"Flight costs {flightCost:C} for {passenger}");
// }
foreach (Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        FirstClassPassenger p => p.AirMiles switch
        {
            > 35000 => 1500M,
            > 15000 => 1750M,
            _ => 2000M
        },
        BusinessClassPassenger => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger => 650M,
        _ => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}

ImmutablePerson jeff = new()
{
    FirstName = "Jeff",
    LastName = "Winger"
};

ImmutableVehicle car = new()
{
    Brand = "Mazda MX-5 RF",
    Color = "Soul Red Crystal Metallic",
    Wheels = 4
};
ImmutableVehicle repaintedCar = car
    with { Color = "Polymetal Grey Metallic"};
WriteLine($"Original car color was {car.Color}.");
WriteLine($"New car color is {repaintedCar.Color}.");

ImmutableAnimal oscar = new("Oscar", "Labrador");
var (who, what) = oscar;
WriteLine($"{who} is a {what}.");