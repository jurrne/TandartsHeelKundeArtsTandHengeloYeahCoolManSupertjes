namespace TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Models
{
    public class Patienten
    {
        public string patient_id { get; set; }

        public string Zorgverzekeraar { get; set; }

        public string Klantnummer { get; set; }
        public Gebruikers Gebruikers { get; set; }
    }
}
