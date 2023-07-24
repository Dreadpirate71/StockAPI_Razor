using Dapper;
using StockAPI_Razor.Data.Entities;

namespace StockAPI_Razor.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly StockContext _context;
        public CustomerRepository(StockContext context )
        {
            _context = context;
        }

        public async Task AddCustomer(Customer customer)
        {
            using var connection = _context.CreateConnection();
            var query = $"INSERT INTO dbo.Customers (FirstName, LastName, Address, City, State, PostalCode, PhoneNumber, Email, Password, AccountBalance)" +
                $"VALUES (@FirstName, @LastName, @Address, @City, @State, @PostalCode, @PhoneNumber, @Email, @Password, @AccountBalance)";
            var result = await connection.QueryAsync<Customer>(query, customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            using var connection = _context.CreateConnection();
            var query = $"SELECT FirstName, LastName, Address, City, State, PostalCode, PhoneNumber, Email, Password, AccountBalance FROM dbo.Customers" +
                        $" WHERE Id = {id}";
            return await connection.QueryFirstOrDefaultAsync<Customer>(query);
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
