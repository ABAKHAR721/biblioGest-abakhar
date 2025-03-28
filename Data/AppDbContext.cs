using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
 
public class AppDbContext : DbContext
{
    public DbSet<Livre> Livres { get; set; }
    public DbSet<Adherent> Adherents { get; set; }
    public DbSet<Emprunt> Emprunts { get; set; }
    public DbSet<Categorie> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql("Host=localhost;Port=5432;Database=biblio_db;Username=postgres;Password=123");
    }
}