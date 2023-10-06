using Microsoft.EntityFrameworkCore;

namespace Packt.Shared;

public class Academy : DbContext
{
    public DbSet<Student>? Students { get; set; }
    public DbSet<Course>? Courses { get; set; }
}