using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StockAPI_Razor.Models
{
    //data template for form to create a new user account
    public class CreateUserModel
    {
        public int Id { get; set; }
        public Guid GuidId { get; set; }
        public string? FirstName { get; set; }
        [Required]

        public string? LastName { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? State { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Phone] 
        public string? PhoneNumber { get; set; }
        [Required]
        [MinLength(5)]
        public string? PostalCode { get; set; }
        [Required]
        [PasswordPropertyText]
        [MinLength(8)]
        public string? Password { get; set; }
        [Required]
        [PasswordPropertyText]
        [Compare("Password")]
        public string? ConfirmPassword { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
