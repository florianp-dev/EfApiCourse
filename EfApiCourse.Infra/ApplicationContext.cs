using EfApiCourse.Infra.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EfApiCourse.Infra;

public class ApplicationContext : DbContext
{
    //private readonly IConfiguration _configuration;
    
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    
    public ApplicationContext(/*IConfiguration configuration*/)
    {
        //_configuration = configuration;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString =
            "Server=localhost;Database=EFCourse;Trusted_Connection=True;TrustServerCertificate=True;"; //_configuration.GetConnectionString("Default");
        optionsBuilder.UseSqlServer(connectionString);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .Property(b => b.Title)
            .IsRequired();
        modelBuilder.Entity<Book>()
            .Property(b => b.PublicationDate)
            .IsRequired()
            .HasColumnType("datetime2");

        modelBuilder.Entity<Author>()
            .Property(a => a.Firstname)
            .IsRequired();
        modelBuilder.Entity<Author>()
            .Property(a => a.Lastname)
            .IsRequired();
    }
}