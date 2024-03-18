using System.ComponentModel.DataAnnotations;

namespace TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Models
{
    public class Patient
    {
        [Key]
        public int ID { get; set; }
        public string? Zorgverzekeraar { get; set; }

        public string? Klantnummer { get; set; }
        public Gebruiker? Gebruiker { get; set; }
    }
}
