using System.ComponentModel.DataAnnotations;

namespace TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Models
{
    public class Kamer
    {
        public int ID { get; set; }
        public string naam { get; set; }
        public Boolean in_gebruik { get; set; }
    }
}
