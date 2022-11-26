using Microsoft.EntityFrameworkCore;

namespace Sportclub;

public class LedenContext : DbContext
{
    public DbSet<Lid> Leden { get; set; }
    public DbSet<Groep> Groepen { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=leden.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Groep>().HasData(
            new Groep { GroepId = 1, Name = "Groep A" },
            new Groep { GroepId = 2, Name = "Groep B" },
            new Groep { GroepId = 3, Name = "Groep C" },
            new Groep { GroepId = 4, Name = "Groep D" });

        modelBuilder.Entity<Lid>().HasData(
            new Lid { LidId = 1, GroepId = 1, Name = "Bart" },
            new Lid { LidId = 2, GroepId = 1, Name = "Jules" },
            new Lid { LidId = 3, GroepId = 1, Name = "Olivia" },
            new Lid { LidId = 4, GroepId = 1, Name = "Ella" },
            new Lid { LidId = 5, GroepId = 1, Name = "Marie" },
            new Lid { LidId = 6, GroepId = 1, Name = "Leon" },
            new Lid { LidId = 7, GroepId = 2, Name = "Mila" },
            new Lid { LidId = 8, GroepId = 2, Name = "Nora" },
            new Lid { LidId = 9, GroepId = 2, Name = "Adam" },
            new Lid { LidId = 10, GroepId = 2, Name = "Lucas" },
            new Lid { LidId = 11, GroepId = 2, Name = "Finn" },
            new Lid { LidId = 12, GroepId = 2, Name = "Emma" },
            new Lid { LidId = 13, GroepId = 3, Name = "Louise" },
            new Lid { LidId = 14, GroepId = 3, Name = "Liam" },
            new Lid { LidId = 15, GroepId = 3, Name = "Lewis" },
            new Lid { LidId = 16, GroepId = 3, Name = "Noor" },
            new Lid { LidId = 17, GroepId = 3, Name = "Matteo" },
            new Lid { LidId = 18, GroepId = 3, Name = "Vic" },
            new Lid { LidId = 19, GroepId = 4, Name = "Lou" },
            new Lid { LidId = 20, GroepId = 4, Name = "Camille" },
            new Lid { LidId = 21, GroepId = 4, Name = "Lina" },
            new Lid { LidId = 22, GroepId = 4, Name = "Anna" },
            new Lid { LidId = 23, GroepId = 4, Name = "Victor" },
            new Lid { LidId = 24, GroepId = 4, Name = "Julie" });
    }
}