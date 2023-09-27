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