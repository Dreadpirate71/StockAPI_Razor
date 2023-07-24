using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StockAPI_Razor.Data.Entities;
using StockAPI_Razor.Data.Repositories;

namespace StockAPI_Razor.Pages.BrokerCompany
{
    public class BrokerDetailsModel : PageModel
    {
        private IBrokerCompanyRepository _brokerCompanyRepository;
        public BrokerDetailsModel(IBrokerCompanyRepository brokerCompanyRepository)
        {
            _brokerCompanyRepository = brokerCompanyRepository;
        }
        [FromRoute]
        public int id { get; set; }
        [BindProperty]
        public BrokerAdmin BrokerDetails { get; set; }
        public async Task<IActionResult> OnGet(int id)
        {
            BrokerDetails = await _brokerCompanyRepository.GetBrokerById(id);
            return Page();
        }
    }
}
