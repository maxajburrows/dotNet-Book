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
