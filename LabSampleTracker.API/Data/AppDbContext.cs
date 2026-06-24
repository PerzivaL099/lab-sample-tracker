using Microsoft.EntityFrameworkCore;
using LabSampleTracker.API.Models; 

namespace LabSampleTracker.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Estas propiedades se convertirán en las tablas de la base de datos
    public DbSet<Patient> Patients { get; set; } = null!;
    public DbSet<Sample> Samples { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuramos el Enum de Status para que se guarde como String en la BD en lugar de un entero.
        // Esto hace que la base de datos sea mucho más legible para auditorías bioinformáticas.
        modelBuilder.Entity<Sample>()
            .Property(s => s.Status)
            .HasConversion<string>();
    }
}