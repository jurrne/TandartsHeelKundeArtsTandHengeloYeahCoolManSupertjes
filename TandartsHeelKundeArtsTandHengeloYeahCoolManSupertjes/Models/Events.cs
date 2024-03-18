using System.ComponentModel.DataAnnotations;

namespace TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Models
{
    public class Event
    {
        [Key]
        public int id { get; set; }
        public Patient Patient { get; set; }
        public Tandarts Tandarts { get; set; }
        public Tandartsassistent Tandartsassistent { get; set; }
        public Kamer Kamer { get; set; }
        public Behandeling Behandeling { get; set; }
        public string? text { get; set; } = string.Empty;
        [Required(ErrorMessage = "Start datum is vereist")]
        public DateTime start_date { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Eind datum is vereist")]
        public DateTime end_date { get; set; }

    }
}
    