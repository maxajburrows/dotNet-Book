using Packt.Shared;

Person max = new();
max.Name = "Max Burrows";
max.DateOfBirth = new DateTime(1997, 11, 5);
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: max.Name,
    arg1: max.DateOfBirth);
WriteLine(max.DateOfBirth);

Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7)
};
WriteLine(format: "{0} was born on {1:dd MMM yy}",
    arg0: alice.Name,
    arg1: alice.DateOfBirth);
