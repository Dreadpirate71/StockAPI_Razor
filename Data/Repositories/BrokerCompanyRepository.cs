using StockAPI_Razor.Data.Entities;
using Dapper;

namespace StockAPI_Razor.Data.Repositories
{
    public class BrokerCompanyRepository : IBrokerCompanyRepository
    {
        private readonly StockContext _context;

        public BrokerCompanyRepository(StockContext context)
        {
            _context = context;
        }

        public async Task AddBroker(BrokerAdmin brokerAdmin)
        {
            var query = $"INSERT INTO dbo.BrokerAdmin (FirstName, LastName, Password, Email) VALUES (@FirstName, @LastName, @Password, @Email)";
            using var connection = _context.CreateConnection();
            var result = await connection.QueryAsync<BrokerAdmin>(query, brokerAdmin);   
        }

        public Task DeleteBroker(BrokerAdmin brokerAdmin)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            var query = $"SELECT Id, FirstName, LastName, Address, City, State, PostalCode, PhoneNumber, Email, Password, AccountBalance FROM dbo.Customers";
            using var connection = _context.CreateConnection();
            var customers = await _context.QueryAsync<Customer>(query);
            return customers.ToList();
        }

        public async Task<BrokerAdmin> GetBrokerById(int id)
        {
            using var connection = _context.CreateConnection();
            var query = $"SELECT Id, FirstName, LastName, Password, Email FROM dbo.BrokerAdmin" +
                        $" WHERE Id = {id}";
            return await connection.QueryFirstOrDefaultAsync<BrokerAdmin>(query);
        }

        public async Task UpdateBroker(BrokerAdmin brokerAdmin)
        {
            using var connection = _context.CreateConnection();
            var query = $"UPDATE dbo.BrokerAdmin SET FirstName = @FirstName, LastName = @LastName, Password = @Password, Email= @Email WHERE Id = @Id";
            await connection.QueryAsync(query, brokerAdmin);
        }
        public async Task<IEnumerable<BrokerAdmin>> GetAllBrokers()
        {
            var query = $"SELECT Id, FirstName, LastName, Password, Email FROM dbo.BrokerAdmin";
            using var connection = _context.CreateConnection();
            var brokers = await _context.QueryAsync<BrokerAdmin>(query);
            return brokers.ToList();
        }
    }
}
