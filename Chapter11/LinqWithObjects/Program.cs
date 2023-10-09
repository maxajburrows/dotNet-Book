using static System.Console;

string[] names = new[] { "Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed"};
SectionTitle("Deferred execution");
var query1 = names.Where(name => name.EndsWith("m"));
var query2 = from name in names where name.EndsWith("m") select name;
string[] result1 = query1.ToArray();
List<string> result2 = query2.ToList();
WriteLine(result1.ToString());
WriteLine(result2.ToString());

foreach (string name in query1)
{
    WriteLine(name);
    names[2] = "Jimmy";
}

SectionTitle("Writing queries");
var query = names.Where(new Func<string, bool>(NameLongerThanFour));
foreach (string item in query)
{
    WriteLine(item);
}
