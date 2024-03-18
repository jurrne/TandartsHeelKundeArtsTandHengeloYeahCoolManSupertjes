using System.ComponentModel.DataAnnotations;


namespace TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Models
{
    public class Gebruiker
    {
        [StringLength(50, ErrorMessage = "Maximumlengte van {0} is {1} tekens")]
        [Key]
        public required int ID { get; set; }
        public string? Voornaam { get; set; }
        public string? Achternaam { get; set; }
        public string? Tussenvoegsel { get; set; }
        public string? Adres { get; set; }
        public string? Postcode { get; set; }
        public string? Woonplaats { get; set; }
        public DateOnly Geboortedatum { get; set; }
        public string? Zorgverzekeraar { get; set; }
        public int Klantnummer { get; set; }
        public string? Email { get; set; }
        public string? Telefoon {  get; set; }
    }
}
