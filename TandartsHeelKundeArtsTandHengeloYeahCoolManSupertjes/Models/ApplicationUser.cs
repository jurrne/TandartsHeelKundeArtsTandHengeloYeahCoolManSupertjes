using Microsoft.AspNetCore.Identity;

namespace TandartsSuperCool.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Infix { get; set; }
        public string? Address { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? HealthInsurer { get; set; }
        public string? CustomerNumber { get; set; }
    }
}
