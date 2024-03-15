using System.ComponentModel.DataAnnotations;

namespace TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Models
{
    public class Behandeling
    {
        public int ID { get; set; }
        public string type { get; set; }
        public int tijd_in_min { get; set; }
        public decimal prijs { get; set; }
    }
}
