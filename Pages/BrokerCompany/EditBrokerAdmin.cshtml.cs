using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockAPI_Razor.Data.Entities;
using StockAPI_Razor.Data.Repositories;
using StockAPI_Razor.Models;

namespace StockAPI_Razor.Pages.BrokerCompany
{
    public class EditBrokerAdminModel : PageModel
    {
        private IBrokerCompanyRepository _brokerCompanyRepository;
        public EditBrokerAdminModel(IBrokerCompanyRepository brokerCompanyRepository)
        {
            _brokerCompanyRepository = brokerCompanyRepository;
        }

        [FromRoute]
        public int id { get; set; }
       
        [BindProperty]
        public BrokerAdmin EditBroker { get; set; }
        BrokerAdmin updateBrokerAdmin = new BrokerAdmin();
        public async Task<IActionResult> OnGet(int id)
        {
            EditBroker = await _brokerCompanyRepository.GetBrokerById(id);
            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            EditBroker.Id = id;
            await _brokerCompanyRepository.UpdateBroker(EditBroker);
            return RedirectToPage("GetAllBrokers");
            

        }
    }
}
