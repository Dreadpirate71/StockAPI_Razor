using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockAPI_Razor.Data.Entities;
using StockAPI_Razor.Data.Repositories;

namespace StockAPI_Razor.Pages.BrokerCompany
{
    public class GetAllBrokersModel : PageModel
    {
        private readonly IBrokerCompanyRepository _brokerCompanyRepository;

        public GetAllBrokersModel(IBrokerCompanyRepository brokerCompanyRepository)
        {
            _brokerCompanyRepository = brokerCompanyRepository;
        }
        public IEnumerable<BrokerAdmin> Brokers { get; set; }
        public async Task<IActionResult> OnGet()
        {
            Brokers = await _brokerCompanyRepository.GetAllBrokers();
            return Page();
        }
    }
}
