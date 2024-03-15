using System.ComponentModel.DataAnnotations;


namespace TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Models
{
    public class Gebruikers
    {
        public int gebruikersID { get; set; }
        [StringLength(50, ErrorMessage = "Maximumlengte van {0} is {1} tekens")]
        public string VoorNaam { get; set; }
        public string Achternaam { get; set; }

    }
}
