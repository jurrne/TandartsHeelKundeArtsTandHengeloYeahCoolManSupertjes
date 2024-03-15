using System.ComponentModel.DataAnnotations;

namespace TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Models
{
    public class Tandartsassistent
    {
        public int ID { get; set; }
        public Gebruikers Gebruiker { get; set; }
    }
}
