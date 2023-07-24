namespace StockAPI_Razor.Data.Entities
{
    public class BrokerAdmin
    {
        public int Id { get; set; }
        public Guid GuidId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
    }
}
