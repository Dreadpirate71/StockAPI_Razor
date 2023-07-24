using StockAPI_Razor.Data.Entities;

namespace StockAPI_Razor.Data.Repositories
{
    public interface ICustomerRepository
    {
        public Task AddCustomer(Customer customer);
        public void UpdateCustomer(Customer customer);
        public void DeleteCustomer(Customer customer); 
        public Task <Customer> GetCustomerById(int id);
        
    }
}
