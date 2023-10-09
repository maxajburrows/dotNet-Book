string[] names = new[] { "Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed"};
SectionTitle("Deferred execution");
var query1 = names.Where(name => name.EndsWith("m"));
var query2 = from name in names where name.EndsWith("m") select name;
string[] result1 = query1.ToArray();
List<string> result2 = query2.ToList();
Console.WriteLine(result1.ToString());
Console.WriteLine(result2.ToString());
foreach (string name in query1)
{
    Console.WriteLine(name);
    names[2] = "Jimmy";
}