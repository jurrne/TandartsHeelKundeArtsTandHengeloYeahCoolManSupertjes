using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Models;

namespace TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Afspraak> Afspraak { get; set; }
        public DbSet<Behandeling> Behandeling { get; set; }
        public DbSet<Gebruiker> Gebruiker { get; set; }
        public DbSet<Kamer> Kamer { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Tandarts> Tandarts { get; set; }
        public DbSet<Tandartsassistent> Tandartsassistent { get; set; }
    }
}
