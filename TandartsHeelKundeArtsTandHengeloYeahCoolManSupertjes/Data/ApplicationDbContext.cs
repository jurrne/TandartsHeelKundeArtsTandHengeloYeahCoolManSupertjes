using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Models;
using TandartsSuperCool.Models;

namespace TandartsSuperCool.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Afspraak> Afspraak { get; set; }
        public DbSet<Behandeling> Behandeling { get; set; }
        public DbSet<Kamer> Kamer { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
