using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StockAPI_Razor.Models
{
    public class CreateBrokerModel
    {
        public int Id { get; set; }
        public Guid GuidId { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        [PasswordPropertyText]
        [MinLength(8)]
        public string? Password { get; set; }
        [Required]
        [PasswordPropertyText]
        [Compare("Password")]
        public string? ConfirmPassword { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

    }
}
