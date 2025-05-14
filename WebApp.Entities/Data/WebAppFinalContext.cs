using Microsoft.EntityFrameworkCore;
using WebApp.Entities.Model;

namespace WebApp.Entities.Data;

public class WebAppFinalContext : DbContext
{
    public WebAppFinalContext()
    {
    }

    public WebAppFinalContext(DbContextOptions<WebAppFinalContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Role { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Name=ConnectionStrings:DefaultConnection");


    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<User>(entity =>
    //     {
    //         entity.HasKey()
    //     });

    // }
}