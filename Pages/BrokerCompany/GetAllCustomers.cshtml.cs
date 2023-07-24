using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using StockAPI_Razor.Data.Entities;
using StockAPI_Razor.Data.Repositories;

namespace StockAPI_Razor.Pages.BrokerCompany
{
    public class GetAllCustomersModel : PageModel
    {
        private IBrokerCompanyRepository _brokerCompanyRepository;

        public IEnumerable<Customer> Customers { get; set; }
        public GetAllCustomersModel(IBrokerCompanyRepository brokerCompanyRepository)
        {
            _brokerCompanyRepository = brokerCompanyRepository;
        }
        
        public async Task<IActionResult> OnGet()
        {
            Customers = await _brokerCompanyRepository.GetAllCustomers(); 
            return Page();
        }
    }
}
