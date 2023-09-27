using System.Globalization;
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