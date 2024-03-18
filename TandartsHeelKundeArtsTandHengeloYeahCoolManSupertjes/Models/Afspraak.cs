using System.ComponentModel.DataAnnotations;

namespace TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Models
{
    public class Afspraak
    {
        public int ID { get; set; }
        public Patient? Patient { get; set; }
        public Tandarts? Tandarts { get; set; }
        public Tandartsassistent? Tandartsassistent { get; set; }
        public Kamer? Kamer { get; set; }
        public Behandeling? Behandeling { get; set; }
        public string? Notitie { get; set; }
        [Required(ErrorMessage = "Datum is vereist")]
        public DateOnly Datum { get; set; }
        [Required(ErrorMessage = "Start tijd is vereist")]
        public TimeOnly Start_tijd { get; set; }
        public TimeOnly Stop_tijd { get; set; }

    }
}
    