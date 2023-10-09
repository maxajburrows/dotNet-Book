using static System.Console;


partial class Program
{
    static bool NameLongerThanFour(string name)
    {
        return name.Length > 4;
    }

    static void Output(IEnumerable<string> cohort, string description = "")
    {
        if (!string.IsNullOrEmpty(description))
        {
            WriteLine(description);
        }
        Write(" ");
    WriteLine(string.Join(", ", cohort.ToArray()));
    WriteLine();
    }
}