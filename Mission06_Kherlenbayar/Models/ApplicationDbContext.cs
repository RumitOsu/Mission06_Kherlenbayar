using Microsoft.EntityFrameworkCore;
using Mission06_Kherlenbayar.Models; // Use your actual namespace here

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure the one-to-many relationship between Category and Movies
        modelBuilder.Entity<Movie>()
            .HasOne(m => m.Category) // Each Movie has one Category
            .WithMany(c => c.Movies) // Each Category has many Movies
            .HasForeignKey(m => m.CategoryId); // The foreign key in the Movie table pointing to Category
    }
}
