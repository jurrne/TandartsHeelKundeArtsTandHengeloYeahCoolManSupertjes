using System.ComponentModel.DataAnnotations;

namespace TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Models
{
    public class Behandeling
    {
        public int ID { get; set; }
        public string? Type { get; set; }
        public int Tijd_in_min { get; set; }
        public int Prijs { get; set; }
    }
}
