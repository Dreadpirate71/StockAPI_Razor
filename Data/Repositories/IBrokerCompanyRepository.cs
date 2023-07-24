using StockAPI_Razor.Data.Entities;

namespace StockAPI_Razor.Data.Repositories
{
    public interface IBrokerCompanyRepository
    {
        public Task <IEnumerable<Customer>> GetAllCustomers();
        public Task AddBroker(BrokerAdmin brokerAdmin);
        public Task DeleteBroker(BrokerAdmin brokerAdmin);
        public Task UpdateBroker(BrokerAdmin brokerAdmin);
        Task<BrokerAdmin> GetBrokerById(int id);
        Task<IEnumerable<BrokerAdmin>> GetAllBrokers();
    }
}
