using System.ComponentModel.DataAnnotations;

namespace TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Models
{
    public class Tandarts
    {
        public int ID { get; set; }
        public Gebruikers Gebruiker { get; set; }
    }
}
