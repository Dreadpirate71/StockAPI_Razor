using System.Text.Json.Serialization;

namespace StockAPI_Razor.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public Guid GuidId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PostalCode { get; set; }
        [JsonIgnore]
        public string? Password { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
