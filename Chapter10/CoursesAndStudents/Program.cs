using Microsoft.EntityFrameworkCore;

using Packt.Shared;

using (Academy a = new())
{
    bool deleted = await a.Database.EnsureDeletedAsync();
    Console.WriteLine($"Database deleted: {deleted}");
    bool created = await a.Database.EnsureCreatedAsync();
    Console.WriteLine($"Database created: {created}");
    Console.WriteLine("SQL script used to create database:");
    Console.WriteLine(a.Database.GenerateCreateScript());

    
    foreach (Student s in a.Students.Include(s => s.Courses))
    {
        Console.WriteLine("{0} {1} attends the following {2} courses:",
            s.FirstName, s.LastName, s.Courses.Count);
        foreach (Course c in s.Courses)
        {
            Console.WriteLine($" {c.Title}");
        }
    }

}
