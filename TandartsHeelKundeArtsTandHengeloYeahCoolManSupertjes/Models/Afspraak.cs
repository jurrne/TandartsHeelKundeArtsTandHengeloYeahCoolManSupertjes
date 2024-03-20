using System.ComponentModel.DataAnnotations;
using TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Models;

namespace TandartsSuperCool.Models
{
    public class Afspraak
    {
        public int ID { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
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
    