using System.ComponentModel.DataAnnotations;

namespace TandartsSuperCool.Models
{
    public class Notitie
    {
        public int ID { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public Afspraak? Afspraak { get; set; }

        [Required(ErrorMessage = "Tekst is vereist")]
        [StringLength(250)]
        public string Tekst { get; set; }
    }
}
