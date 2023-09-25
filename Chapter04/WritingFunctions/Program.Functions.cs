partial class Program
{
    static void TimeTable(byte number, byte size=12)
    {
        WriteLine($"This is the {number} times table with {size} rows:");
        for (int row=1; row <= size; row++)
        {
            WriteLine($"")
        }
    }
}