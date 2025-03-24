using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
namespace DemoMVC.Data;
public class ApplicationDbcontext : DbContext
{
    internal readonly object HTTP;

    public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
    {}
    public DbSet<Person> Person { get; set; } = default!;
    // public DbSet<Student> Student { get; set; } = default!;
     public DbSet<Person> Employee { get; set; } = default!;
}