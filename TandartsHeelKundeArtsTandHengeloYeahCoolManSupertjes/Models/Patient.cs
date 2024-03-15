namespace TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Models
{
    public class Patient
    {
        public string patient_id { get; set; }

        public string Zorgverzekeraar { get; set; }

        public string Klantnummer { get; set; }
        public Gebruiker Gebruiker { get; set; }
    }
}
