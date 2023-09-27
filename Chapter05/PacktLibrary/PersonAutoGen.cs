namespace Packt.Shared;

public partial class Person 
{
    public string Origin 
    {
        get
        {
            return string.Format("{0} was born on {1}",
                arg0: Name, arg1: HomePlanet);
        }
    }
    public string Greeting => $"{Name} says 'Hello!'";
    public int Age => DateTime.Today.Year - DateOfBirth.Year;
    public string? FavouriteIceCream { get; set; }
}