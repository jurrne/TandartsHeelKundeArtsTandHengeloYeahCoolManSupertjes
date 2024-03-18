using System.ComponentModel.DataAnnotations;

namespace TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Models
{
    public class Kamer
    {
        public int ID { get; set; }
        public string? Naam { get; set; }
        public Boolean In_gebruik { get; set; }
    }
}
